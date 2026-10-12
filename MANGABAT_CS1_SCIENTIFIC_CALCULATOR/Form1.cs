using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MANGABAT_CS1_SCIENTIFIC_CALCULATOR
{
    public partial class Form1 : Form
    {
        // Calculator State Variables
        private string currentInput = "0";
        private string expressionString = "";
        private double resultValue = 0;
        private string lastOperator = "";
        private bool isNewCalculation = true;
        private bool isDegreeMode = true;
        private bool isShiftActive = false;

        // DLL Imports for dragging the borderless custom window
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
            SetupEventHandlers();
            ConfigureWindowDragging();
        }

        // --- HOOK UP ALL BUTTON EVENTS SAFELY ---
        private void SetupEventHandlers()
        {
            // OFF Button closes application
            if (btnClose != null) btnClose.Click += (s, e) => Application.Exit();

            // Mode & Degree/Radian Toggle
            if (btnDegRad != null)
            {
                btnDegRad.Click += (s, e) =>
                {
                    isDegreeMode = !isDegreeMode;
                    btnDegRad.Text = isDegreeMode ? "Deg" : "Rad";
                };
            }

            // Shift Button Toggle
            if (btnShift != null)
            {
                btnShift.Click += (s, e) => {
                    isShiftActive = !isShiftActive;
                    // Turns yellow when active, orange/gold when inactive
                    btnShift.BackColor = isShiftActive ? Color.Yellow : Color.FromArgb(210, 160, 30);
                    btnShift.ForeColor = isShiftActive ? Color.Black : Color.White;
                };
            }

            // Number Buttons (0 - 9)
            Button[] numButtons = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var btn in numButtons)
            {
                if (btn != null) btn.Click += NumberButton_Click;
            }

            // Decimal & Sign Change
            if (btnDecimal != null) btnDecimal.Click += BtnDecimal_Click;
            if (btnSign != null) btnSign.Click += BtnSign_Click;

            // Basic Arithmetic Operators (+, -, ×, ÷, ^)
            if (btnPlus != null) btnPlus.Click += (s, e) => OperatorButton_Click("+");
            if (btnSubtract != null) btnSubtract.Click += (s, e) => OperatorButton_Click("-");
            if (btnMultiply != null) btnMultiply.Click += (s, e) => OperatorButton_Click("×");
            if (btnDivide != null) btnDivide.Click += (s, e) => OperatorButton_Click("÷");
            if (btnPower != null) btnPower.Click += (s, e) => OperatorButton_Click("^");

            // Equals & Clears
            if (btnEquals != null) btnEquals.Click += BtnEquals_Click;
            if (btnClear != null) btnClear.Click += (s, e) => ClearAll();
            if (btnCE != null) btnCE.Click += (s, e) => ClearEntry();
            if (btnBack != null) btnBack.Click += (s, e) => Backspace();

            // Scientific Unary Functions
            if (btnSquare != null) btnSquare.Click += (s, e) => UnaryFunction("sqr");
            if (btnSqrt != null) btnSqrt.Click += (s, e) => UnaryFunction("sqrt");
            if (btnReciprocal != null) btnReciprocal.Click += (s, e) => UnaryFunction("recip");

            // Trigonometry with Shift check for Inverse Trig (arcsin, arccos, arctan)
            if (btnSin != null)
            {
                btnSin.Click += (s, e) => {
                    if (isShiftActive)
                    {
                        isShiftActive = false;
                        btnShift.BackColor = Color.FromArgb(210, 160, 30); // Reset shift light
                        btnShift.ForeColor = Color.White;
                        UnaryFunction("arcsin");
                    }
                    else { UnaryFunction("sin"); }
                };
            }

            if (btnCos != null)
            {
                btnCos.Click += (s, e) => {
                    if (isShiftActive)
                    {
                        isShiftActive = false;
                        btnShift.BackColor = Color.FromArgb(210, 160, 30);
                        btnShift.ForeColor = Color.White;
                        UnaryFunction("arccos");
                    }
                    else { UnaryFunction("cos"); }
                };
            }

            if (btnTan != null)
            {
                btnTan.Click += (s, e) => {
                    if (isShiftActive)
                    {
                        isShiftActive = false;
                        btnShift.BackColor = Color.FromArgb(210, 160, 30);
                        btnShift.ForeColor = Color.White;
                        UnaryFunction("arctan");
                    }
                    else { UnaryFunction("tan"); }
                };
            }

            if (btnLog != null) btnLog.Click += (s, e) => UnaryFunction("log");
            if (btnLn != null) btnLn.Click += (s, e) => UnaryFunction("ln");
            if (btnPercent != null) btnPercent.Click += (s, e) => UnaryFunction("percent");

            // Constants
            if (btnPi != null) btnPi.Click += (s, e) => InsertConstant(Math.PI);
            if (btnE != null) btnE.Click += (s, e) => InsertConstant(Math.E);
            if (btnExp != null) btnExp.Click += (s, e) => InsertConstant(1e3);

            // Parentheses
            if (btnOpenParen != null) btnOpenParen.Click += (s, e) => AppendExpression("(");
            if (btnCloseParen != null) btnCloseParen.Click += (s, e) => AppendExpression(")");
        }

        // --- PHYSICAL KEYBOARD SUPPORT ---
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData >= Keys.D0 && keyData <= Keys.D9) || (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9))
            {
                char digit = (char)('0' + (keyData - (keyData >= Keys.NumPad0 ? Keys.NumPad0 : Keys.D0)));
                AppendDigit(digit.ToString());
                return true;
            }

            if (keyData == Keys.Decimal || keyData == Keys.OemPeriod)
            {
                BtnDecimal_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.Add || keyData == (Keys.Shift | Keys.Oemplus)) { OperatorButton_Click("+"); return true; }
            if (keyData == Keys.Subtract || keyData == Keys.OemMinus) { OperatorButton_Click("-"); return true; }
            if (keyData == Keys.Multiply || keyData == (Keys.Shift | Keys.D8)) { OperatorButton_Click("×"); return true; }
            if (keyData == Keys.Divide || keyData == Keys.OemQuestion) { OperatorButton_Click("÷"); return true; }

            if (keyData == Keys.Enter || keyData == Keys.Return)
            {
                BtnEquals_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.Back)
            {
                Backspace();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                ClearAll();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AppendDigit(string digit)
        {
            if (currentInput == "0" || isNewCalculation || currentInput.Contains("Error"))
            {
                currentInput = digit;
                isNewCalculation = false;
            }
            else
            {
                currentInput += digit;
            }
            UpdateDisplay();
        }

        // --- WINDOW DRAGGING SUPPORT ---
        private void ConfigureWindowDragging()
        {
            if (pnlHeader != null)
            {
                pnlHeader.MouseDown += HeaderPanel_MouseDown;
            }
            if (label1 != null)
            {
                label1.MouseDown += HeaderPanel_MouseDown;
            }
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // --- NUMBER & INPUT LOGIC ---
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AppendDigit(btn.Text);
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (isNewCalculation || currentInput.Contains("Error"))
            {
                currentInput = "0.";
                isNewCalculation = false;
            }
            else if (!currentInput.Contains("."))
            {
                currentInput += ".";
            }
            UpdateDisplay();
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            if (double.TryParse(currentInput, out double val))
            {
                currentInput = (-val).ToString();
                UpdateDisplay();
            }
        }

        private void InsertConstant(double val)
        {
            currentInput = val.ToString();
            isNewCalculation = false;
            UpdateDisplay();
        }

        private void AppendExpression(string val)
        {
            expressionString += " " + val + " ";
            UpdateDisplay();
        }

        // --- ARITHMETIC OPERATORS ---
        private void OperatorButton_Click(string op)
        {
            try
            {
                if (double.TryParse(currentInput, out double val))
                {
                    if (string.IsNullOrEmpty(lastOperator))
                    {
                        resultValue = val;
                    }
                    else
                    {
                        resultValue = CalculateBinary(resultValue, val, lastOperator);
                    }

                    lastOperator = op;
                    expressionString = $"{resultValue} {op} ";
                    currentInput = "0";
                    isNewCalculation = true;
                    UpdateDisplay();
                }
            }
            catch (Exception)
            {
                ShowError("Math Error");
            }
        }

        private double CalculateBinary(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "×": return a * b;
                case "÷":
                    if (b == 0) throw new DivideByZeroException();
                    return a / b;
                case "^": return Math.Pow(a, b);
                default: return b;
            }
        }

        // --- SCIENTIFIC UNARY FUNCTIONS ---
        private void UnaryFunction(string func)
        {
            try
            {
                if (!double.TryParse(currentInput, out double val)) return;

                double res = 0;
                switch (func)
                {
                    case "sqr":
                        expressionString = $"sqr({val})";
                        res = val * val;
                        break;
                    case "sqrt":
                        if (val < 0) { ShowError("Error"); return; }
                        expressionString = $"√({val})";
                        res = Math.Sqrt(val);
                        break;
                    case "recip":
                        if (val == 0) { ShowError("Error"); return; }
                        expressionString = $"1/({val})";
                        res = 1 / val;
                        break;
                    case "sin":
                        double sinAngle = isDegreeMode ? val * (Math.PI / 180.0) : val;
                        expressionString = $"sin({val}°)";
                        res = Math.Sin(sinAngle);
                        break;
                    case "cos":
                        double cosAngle = isDegreeMode ? val * (Math.PI / 180.0) : val;
                        expressionString = $"cos({val}°)";
                        res = Math.Cos(cosAngle);
                        break;
                    case "tan":
                        if (isDegreeMode && (Math.Abs(val % 180) == 90)) { ShowError("Error"); return; }
                        double tanAngle = isDegreeMode ? val * (Math.PI / 180.0) : val;
                        expressionString = $"tan({val}°)";
                        res = Math.Tan(tanAngle);
                        break;
                    case "log":
                        if (val <= 0) { ShowError("Error"); return; }
                        expressionString = $"log({val})";
                        res = Math.Log10(val);
                        break;
                    case "ln":
                        if (val <= 0) { ShowError("Error"); return; }
                        expressionString = $"ln({val})";
                        res = Math.Log(val);
                        break;
                    case "percent":
                        res = val / 100.0;
                        expressionString = $"{val}%";
                        break;
                    case "arcsin":
                        if (val < -1 || val > 1) { ShowError("Error"); return; }
                        double asinRad = Math.Asin(val);
                        res = isDegreeMode ? asinRad * (180.0 / Math.PI) : asinRad;
                        expressionString = $"sin⁻¹({val})";
                        break;
                    case "arccos":
                        if (val < -1 || val > 1) { ShowError("Error"); return; }
                        double acosRad = Math.Acos(val);
                        res = isDegreeMode ? acosRad * (180.0 / Math.PI) : acosRad;
                        expressionString = $"cos⁻¹({val})";
                        break;
                    case "arctan":
                        double atanRad = Math.Atan(val);
                        res = isDegreeMode ? atanRad * (180.0 / Math.PI) : atanRad;
                        expressionString = $"tan⁻¹({val})";
                        break;
                }

                currentInput = res.ToString();
                isNewCalculation = true;
                UpdateDisplay();
            }
            catch (Exception)
            {
                ShowError("Math Error");
            }
        }

        // --- EQUALS & EVALUATION ---
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lastOperator))
                {
                    if (double.TryParse(currentInput, out double val))
                    {
                        expressionString += $"{currentInput} =";
                        resultValue = CalculateBinary(resultValue, val, lastOperator);
                        currentInput = resultValue.ToString();
                        lastOperator = "";
                        isNewCalculation = true;
                        UpdateDisplay();
                    }
                }
            }
            catch (Exception)
            {
                ShowError("Error");
            }
        }

        // --- CLEAR & RESET CONTROLS ---
        private void ClearAll()
        {
            currentInput = "0";
            expressionString = "";
            resultValue = 0;
            lastOperator = "";
            isNewCalculation = true;
            isShiftActive = false;
            if (btnShift != null)
            {
                btnShift.BackColor = Color.FromArgb(210, 160, 30);
                btnShift.ForeColor = Color.White;
            }
            UpdateDisplay();
        }

        private void ClearEntry()
        {
            currentInput = "0";
            isNewCalculation = true;
            UpdateDisplay();
        }

        private void Backspace()
        {
            if (!isNewCalculation && currentInput.Length > 0 && !currentInput.Contains("Error"))
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                if (currentInput == "" || currentInput == "-") currentInput = "0";
                UpdateDisplay();
            }
        }

        // --- DISPLAY HELPERS ---
        private void UpdateDisplay()
        {
            if (txtResult != null) txtResult.Text = currentInput;
            if (txtExpression != null) txtExpression.Text = expressionString;
        }

        private void ShowError(string message)
        {
            currentInput = message;
            expressionString = "";
            lastOperator = "";
            isNewCalculation = true;
            isShiftActive = false;
            if (txtResult != null) txtResult.Text = currentInput;
            if (txtExpression != null) txtExpression.Text = "";
        }

        // Dummy event handlers required by the designer file
        private void label1_Click(object sender, EventArgs e) { }
        private void pnlScreenContainer_Paint(object sender, PaintEventArgs e) { }
        private void txtExpression_TextChanged(object sender, EventArgs e) { }
        private void txtResult_TextChanged(object sender, EventArgs e) { }
        private void buttonGrid_Paint(object sender, PaintEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
    }
}