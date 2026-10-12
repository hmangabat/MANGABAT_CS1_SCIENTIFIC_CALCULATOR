using System;
using System.Drawing;
using System.Windows.Forms;

namespace MANGABAT_CS1_SCIENTIFIC_CALCULATOR
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            label1 = new Label();
            pnlScreenContainer = new FlowLayoutPanel();
            txtExpression = new TextBox();
            txtResult = new TextBox();
            pnlTopControls = new Panel();
            btnDegRad = new Button();
            btnShift = new Button();
            buttonGrid = new TableLayoutPanel();
            btnEquals = new Button();
            btnPlus = new Button();
            btnExp = new Button();
            btnDecimal = new Button();
            btnSign = new Button();
            btnSubtract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnPercent = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btnBack = new Button();
            btnDivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnClear = new Button();
            btnCE = new Button();
            btnE = new Button();
            btnPi = new Button();
            btnPower = new Button();
            btnLn = new Button();
            btnLog = new Button();
            btnTan = new Button();
            btnCos = new Button();
            btnSin = new Button();
            btnOpenParen = new Button();
            btnReciprocal = new Button();
            btnSqrt = new Button();
            btnSquare = new Button();
            btnCloseParen = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            pnlScreenContainer.SuspendLayout();
            pnlTopControls.SuspendLayout();
            buttonGrid.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSlateGray;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = Color.LightSlateGray;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(626, 45);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(607, 29);
            label1.TabIndex = 0;
            label1.Text = "Canon                                                     F-789SGA";
            label1.Click += label1_Click_1;
            // 
            // pnlScreenContainer
            // 
            pnlScreenContainer.BackColor = Color.FromArgb(180, 195, 175);
            pnlScreenContainer.Controls.Add(txtExpression);
            pnlScreenContainer.Controls.Add(txtResult);
            pnlScreenContainer.Dock = DockStyle.Top;
            pnlScreenContainer.Location = new Point(0, 45);
            pnlScreenContainer.Name = "pnlScreenContainer";
            pnlScreenContainer.Padding = new Padding(6);
            pnlScreenContainer.Size = new Size(626, 110);
            pnlScreenContainer.TabIndex = 2;
            // 
            // txtExpression
            // 
            txtExpression.BackColor = Color.FromArgb(180, 195, 175);
            txtExpression.BorderStyle = BorderStyle.None;
            txtExpression.Dock = DockStyle.Top;
            txtExpression.Font = new Font("Consolas", 11F);
            txtExpression.ForeColor = Color.FromArgb(60, 70, 60);
            txtExpression.Location = new Point(9, 9);
            txtExpression.Name = "txtExpression";
            txtExpression.ReadOnly = true;
            txtExpression.Size = new Size(570, 35);
            txtExpression.TabIndex = 0;
            txtExpression.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(180, 195, 175);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Dock = DockStyle.Bottom;
            txtResult.Font = new Font("Consolas", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.Black;
            txtResult.Location = new Point(9, 50);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(570, 63);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // pnlTopControls
            // 
            pnlTopControls.BackColor = Color.LightSlateGray;
            pnlTopControls.Controls.Add(btnDegRad);
            pnlTopControls.Controls.Add(btnShift);
            pnlTopControls.Controls.Add(btnClose);
            pnlTopControls.Dock = DockStyle.Top;
            pnlTopControls.Location = new Point(0, 155);
            pnlTopControls.Name = "pnlTopControls";
            pnlTopControls.Size = new Size(626, 77);
            pnlTopControls.TabIndex = 3;
            // 
            // btnDegRad
            // 
            btnDegRad.BackColor = Color.FromArgb(60, 65, 70);
            btnDegRad.FlatStyle = FlatStyle.Flat;
            btnDegRad.Font = new Font("Segoe UI", 10F);
            btnDegRad.ForeColor = Color.White;
            btnDegRad.Location = new Point(427, 0);
            btnDegRad.Name = "btnDegRad";
            btnDegRad.Size = new Size(199, 86);
            btnDegRad.TabIndex = 3;
            btnDegRad.Text = "Deg";
            btnDegRad.UseVisualStyleBackColor = false;
            // 
            // btnShift
            // 
            btnShift.BackColor = Color.FromArgb(60, 65, 70);
            btnShift.FlatStyle = FlatStyle.Flat;
            btnShift.Font = new Font("Segoe UI", 10F);
            btnShift.ForeColor = Color.White;
            btnShift.Location = new Point(0, 0);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(206, 86);
            btnShift.TabIndex = 0;
            btnShift.Text = "Shift";
            btnShift.UseVisualStyleBackColor = false;
            // 
            // buttonGrid
            // 
            buttonGrid.BackColor = Color.LightSlateGray;
            buttonGrid.ColumnCount = 5;
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.0612259F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9387741F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            buttonGrid.Controls.Add(btnEquals, 4, 6);
            buttonGrid.Controls.Add(btnPlus, 3, 6);
            buttonGrid.Controls.Add(btnExp, 2, 6);
            buttonGrid.Controls.Add(btnDecimal, 1, 6);
            buttonGrid.Controls.Add(btnSign, 4, 5);
            buttonGrid.Controls.Add(btnSubtract, 3, 5);
            buttonGrid.Controls.Add(btn3, 2, 5);
            buttonGrid.Controls.Add(btn2, 1, 5);
            buttonGrid.Controls.Add(btnPercent, 4, 4);
            buttonGrid.Controls.Add(btnMultiply, 3, 4);
            buttonGrid.Controls.Add(btn6, 2, 4);
            buttonGrid.Controls.Add(btn5, 1, 4);
            buttonGrid.Controls.Add(btnBack, 4, 3);
            buttonGrid.Controls.Add(btnDivide, 3, 3);
            buttonGrid.Controls.Add(btn9, 2, 3);
            buttonGrid.Controls.Add(btn8, 1, 3);
            buttonGrid.Controls.Add(btnClear, 4, 2);
            buttonGrid.Controls.Add(btnCE, 3, 2);
            buttonGrid.Controls.Add(btnE, 2, 2);
            buttonGrid.Controls.Add(btnPi, 1, 2);
            buttonGrid.Controls.Add(btnPower, 0, 2);
            buttonGrid.Controls.Add(btnLn, 4, 1);
            buttonGrid.Controls.Add(btnLog, 3, 1);
            buttonGrid.Controls.Add(btnTan, 2, 1);
            buttonGrid.Controls.Add(btnCos, 1, 1);
            buttonGrid.Controls.Add(btnSin, 0, 1);
            buttonGrid.Controls.Add(btnOpenParen, 3, 0);
            buttonGrid.Controls.Add(btnReciprocal, 2, 0);
            buttonGrid.Controls.Add(btnSqrt, 1, 0);
            buttonGrid.Controls.Add(btnSquare, 0, 0);
            buttonGrid.Controls.Add(btnCloseParen, 4, 0);
            buttonGrid.Controls.Add(btn7, 0, 3);
            buttonGrid.Controls.Add(btn4, 0, 4);
            buttonGrid.Controls.Add(btn0, 0, 6);
            buttonGrid.Controls.Add(btn1, 0, 5);
            buttonGrid.Dock = DockStyle.Bottom;
            buttonGrid.Location = new Point(0, 235);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.RowCount = 7;
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 49.4736824F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50.5263176F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            buttonGrid.Size = new Size(626, 588);
            buttonGrid.TabIndex = 2;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.RosyBrown;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Segoe UI", 10F);
            btnEquals.ForeColor = SystemColors.ButtonFace;
            btnEquals.Location = new Point(504, 490);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(119, 82);
            btnEquals.TabIndex = 34;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Black;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 10F);
            btnPlus.ForeColor = SystemColors.ButtonFace;
            btnPlus.Location = new Point(381, 490);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(117, 82);
            btnPlus.TabIndex = 33;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            // 
            // btnExp
            // 
            btnExp.BackColor = Color.Black;
            btnExp.FlatStyle = FlatStyle.Flat;
            btnExp.Font = new Font("Segoe UI", 10F);
            btnExp.ForeColor = SystemColors.ButtonFace;
            btnExp.Location = new Point(258, 490);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(117, 82);
            btnExp.TabIndex = 32;
            btnExp.Text = "EXP";
            btnExp.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Black;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Segoe UI", 10F);
            btnDecimal.ForeColor = SystemColors.ButtonFace;
            btnDecimal.Location = new Point(138, 490);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(113, 82);
            btnDecimal.TabIndex = 31;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.Black;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI", 10F);
            btnSign.ForeColor = SystemColors.ButtonFace;
            btnSign.Location = new Point(504, 396);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(119, 78);
            btnSign.TabIndex = 29;
            btnSign.Text = "±";
            btnSign.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Black;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI", 10F);
            btnSubtract.ForeColor = SystemColors.ButtonFace;
            btnSubtract.Location = new Point(381, 396);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(117, 78);
            btnSubtract.TabIndex = 28;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DarkSlateGray;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 10F);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(258, 396);
            btn3.Name = "btn3";
            btn3.Size = new Size(117, 78);
            btn3.TabIndex = 27;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DarkSlateGray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 10F);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(138, 396);
            btn2.Name = "btn2";
            btn2.Size = new Size(113, 78);
            btn2.TabIndex = 26;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.Black;
            btnPercent.FlatStyle = FlatStyle.Flat;
            btnPercent.Font = new Font("Segoe UI", 10F);
            btnPercent.ForeColor = SystemColors.ButtonFace;
            btnPercent.Location = new Point(504, 296);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(119, 82);
            btnPercent.TabIndex = 24;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Black;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 10F);
            btnMultiply.ForeColor = SystemColors.ButtonFace;
            btnMultiply.Location = new Point(381, 296);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(117, 82);
            btnMultiply.TabIndex = 23;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DarkSlateGray;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 10F);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(258, 296);
            btn6.Name = "btn6";
            btn6.Size = new Size(117, 82);
            btn6.TabIndex = 22;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DarkSlateGray;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 10F);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(138, 296);
            btn5.Name = "btn5";
            btn5.Size = new Size(113, 82);
            btn5.TabIndex = 21;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RosyBrown;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(504, 195);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 82);
            btnBack.TabIndex = 19;
            btnBack.Text = "⌫";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Black;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 10F);
            btnDivide.ForeColor = SystemColors.ButtonFace;
            btnDivide.Location = new Point(381, 195);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(117, 82);
            btnDivide.TabIndex = 18;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DarkSlateGray;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 10F);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(258, 195);
            btn9.Name = "btn9";
            btn9.Size = new Size(117, 82);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DarkSlateGray;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 10F);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(138, 195);
            btn8.Name = "btn8";
            btn8.Size = new Size(113, 82);
            btn8.TabIndex = 16;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ScrollBar;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(504, 129);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 51);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.ScrollBar;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Segoe UI", 10F);
            btnCE.ForeColor = SystemColors.ActiveCaptionText;
            btnCE.Location = new Point(381, 129);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(117, 51);
            btnCE.TabIndex = 13;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = SystemColors.ScrollBar;
            btnE.FlatStyle = FlatStyle.Flat;
            btnE.Font = new Font("Segoe UI", 10F);
            btnE.ForeColor = SystemColors.ActiveCaptionText;
            btnE.Location = new Point(258, 129);
            btnE.Name = "btnE";
            btnE.Size = new Size(117, 51);
            btnE.TabIndex = 12;
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = false;
            // 
            // btnPi
            // 
            btnPi.BackColor = SystemColors.ScrollBar;
            btnPi.FlatStyle = FlatStyle.Flat;
            btnPi.Font = new Font("Segoe UI", 10F);
            btnPi.ForeColor = SystemColors.ActiveCaptionText;
            btnPi.Location = new Point(138, 129);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(113, 51);
            btnPi.TabIndex = 11;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            // 
            // btnPower
            // 
            btnPower.BackColor = SystemColors.ScrollBar;
            btnPower.FlatStyle = FlatStyle.Flat;
            btnPower.Font = new Font("Segoe UI", 10F);
            btnPower.ForeColor = SystemColors.ActiveCaptionText;
            btnPower.Location = new Point(3, 129);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(129, 51);
            btnPower.TabIndex = 10;
            btnPower.Text = "xʸ";
            btnPower.UseVisualStyleBackColor = false;
            // 
            // btnLn
            // 
            btnLn.BackColor = SystemColors.ScrollBar;
            btnLn.FlatStyle = FlatStyle.Flat;
            btnLn.Font = new Font("Segoe UI", 10F);
            btnLn.ForeColor = SystemColors.ActiveCaptionText;
            btnLn.Location = new Point(504, 65);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(119, 51);
            btnLn.TabIndex = 9;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            btnLog.BackColor = SystemColors.ScrollBar;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 10F);
            btnLog.ForeColor = SystemColors.ActiveCaptionText;
            btnLog.Location = new Point(381, 65);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(117, 51);
            btnLog.TabIndex = 8;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // btnTan
            // 
            btnTan.BackColor = SystemColors.ScrollBar;
            btnTan.FlatStyle = FlatStyle.Flat;
            btnTan.Font = new Font("Segoe UI", 10F);
            btnTan.ForeColor = SystemColors.ActiveCaptionText;
            btnTan.Location = new Point(258, 65);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(117, 51);
            btnTan.TabIndex = 7;
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = false;
            // 
            // btnCos
            // 
            btnCos.BackColor = SystemColors.ScrollBar;
            btnCos.FlatStyle = FlatStyle.Flat;
            btnCos.Font = new Font("Segoe UI", 10F);
            btnCos.ForeColor = SystemColors.ActiveCaptionText;
            btnCos.Location = new Point(138, 65);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(113, 51);
            btnCos.TabIndex = 6;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            // 
            // btnSin
            // 
            btnSin.BackColor = SystemColors.ScrollBar;
            btnSin.FlatStyle = FlatStyle.Flat;
            btnSin.Font = new Font("Segoe UI", 10F);
            btnSin.ForeColor = SystemColors.ActiveCaptionText;
            btnSin.Location = new Point(3, 65);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(129, 51);
            btnSin.TabIndex = 5;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            // 
            // btnOpenParen
            // 
            btnOpenParen.BackColor = SystemColors.ScrollBar;
            btnOpenParen.FlatStyle = FlatStyle.Flat;
            btnOpenParen.Font = new Font("Segoe UI", 10F);
            btnOpenParen.ForeColor = SystemColors.ActiveCaptionText;
            btnOpenParen.Location = new Point(381, 3);
            btnOpenParen.Name = "btnOpenParen";
            btnOpenParen.Size = new Size(117, 50);
            btnOpenParen.TabIndex = 3;
            btnOpenParen.Text = "(";
            btnOpenParen.UseVisualStyleBackColor = false;
            // 
            // btnReciprocal
            // 
            btnReciprocal.BackColor = SystemColors.ScrollBar;
            btnReciprocal.FlatStyle = FlatStyle.Flat;
            btnReciprocal.Font = new Font("Segoe UI", 10F);
            btnReciprocal.ForeColor = SystemColors.ActiveCaptionText;
            btnReciprocal.Location = new Point(258, 3);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(117, 50);
            btnReciprocal.TabIndex = 2;
            btnReciprocal.Text = "1/x";
            btnReciprocal.UseVisualStyleBackColor = false;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = SystemColors.ScrollBar;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Font = new Font("Segoe UI", 10F);
            btnSqrt.ForeColor = SystemColors.ActiveCaptionText;
            btnSqrt.Location = new Point(138, 3);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(114, 50);
            btnSqrt.TabIndex = 1;
            btnSqrt.Text = "√x";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = SystemColors.ScrollBar;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Segoe UI", 10F);
            btnSquare.ForeColor = SystemColors.ActiveCaptionText;
            btnSquare.Location = new Point(3, 3);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(129, 50);
            btnSquare.TabIndex = 0;
            btnSquare.Text = " x²";
            btnSquare.UseVisualStyleBackColor = false;
            // 
            // btnCloseParen
            // 
            btnCloseParen.BackColor = SystemColors.ScrollBar;
            btnCloseParen.FlatStyle = FlatStyle.Flat;
            btnCloseParen.Font = new Font("Segoe UI", 10F);
            btnCloseParen.ForeColor = SystemColors.ActiveCaptionText;
            btnCloseParen.Location = new Point(504, 3);
            btnCloseParen.Name = "btnCloseParen";
            btnCloseParen.Size = new Size(119, 50);
            btnCloseParen.TabIndex = 4;
            btnCloseParen.Text = ")";
            btnCloseParen.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DarkSlateGray;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 10F);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(3, 195);
            btn7.Name = "btn7";
            btn7.Size = new Size(129, 82);
            btn7.TabIndex = 15;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkSlateGray;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 10F);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(3, 296);
            btn4.Name = "btn4";
            btn4.Size = new Size(129, 82);
            btn4.TabIndex = 20;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DarkSlateGray;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 10F);
            btn0.ForeColor = SystemColors.ButtonFace;
            btn0.Location = new Point(3, 490);
            btn0.Name = "btn0";
            btn0.Size = new Size(129, 82);
            btn0.TabIndex = 25;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DarkSlateGray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 10F);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(3, 396);
            btn1.Name = "btn1";
            btn1.Size = new Size(129, 78);
            btn1.TabIndex = 30;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(128, 64, 64);
            btnClose.Dock = DockStyle.Top;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8F);
            btnClose.ForeColor = Color.Transparent;
            btnClose.Location = new Point(0, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(626, 86);
            btnClose.TabIndex = 4;
            btnClose.Text = "Off";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 38, 41);
            ClientSize = new Size(626, 823);
            Controls.Add(pnlTopControls);
            Controls.Add(pnlScreenContainer);
            Controls.Add(buttonGrid);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Canon F-789SGA II Emulator";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlScreenContainer.ResumeLayout(false);
            pnlScreenContainer.PerformLayout();
            pnlTopControls.ResumeLayout(false);
            buttonGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private FlowLayoutPanel pnlScreenContainer;
        private TextBox txtExpression;
        private TextBox txtResult;
        private Panel pnlTopControls;
        private Button btnDegRad;
        private Button btnShift;
        private TableLayoutPanel buttonGrid;
        private Button btnSquare;
        private Button btnOpenParen;
        private Button btnReciprocal;
        private Button btnSqrt;
        private Button btnLn;
        private Button btnLog;
        private Button btnTan;
        private Button btnCos;
        private Button btnSin;
        private Button btnCloseParen;
        private Button btnClear;
        private Button btnCE;
        private Button btnE;
        private Button btnPi;
        private Button btnPower;
        private Button btn7;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnBack;
        private Button btnDivide;
        private Button btn9;
        private Button btn8;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnExp;
        private Button btnDecimal;
        private Button btnSign;
        private Button btnSubtract;
        private Button btn3;
        private Button btn2;
        private Button btnPercent;
        private Button btn0;
        private Button btn1;
        private Button btnClose;
    }
}