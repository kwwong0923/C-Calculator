namespace MyCalculator
{
    partial class formCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculator));
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.rdoScientfic = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.tabApp = new System.Windows.Forms.TabControl();
            this.tpCalculator = new System.Windows.Forms.TabPage();
            this.btn1x = new System.Windows.Forms.Button();
            this.lblStep = new System.Windows.Forms.Label();
            this.btnBS = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnLuckyNum = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnXSquareY = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSine = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.tpAboutMe = new System.Windows.Forms.TabPage();
            this.picWinter = new System.Windows.Forms.PictureBox();
            this.rdoWinter = new System.Windows.Forms.RadioButton();
            this.rdoSummer = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picSummer = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabApp.SuspendLayout();
            this.tpCalculator.SuspendLayout();
            this.tpAboutMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.SlateGray;
            this.btnRoot.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRoot.Location = new System.Drawing.Point(329, 372);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(59, 61);
            this.btnRoot.TabIndex = 41;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEqual.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(392, 219);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(47, 214);
            this.btnEqual.TabIndex = 40;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDivide.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivide.Location = new System.Drawing.Point(328, 296);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(59, 61);
            this.btnDivide.TabIndex = 39;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnBasicCal_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMultiply.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiply.Location = new System.Drawing.Point(263, 296);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(59, 61);
            this.btnMultiply.TabIndex = 38;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnBasicCal_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSubtract.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubtract.Location = new System.Drawing.Point(329, 220);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(59, 61);
            this.btnSubtract.TabIndex = 37;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnBasicCal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(264, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 61);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnBasicCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(279, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 61);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "&CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(6, 370);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 61);
            this.btn0.TabIndex = 34;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Black;
            this.btnPoint.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoint.Location = new System.Drawing.Point(97, 370);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(70, 61);
            this.btnPoint.TabIndex = 33;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.Black;
            this.btnPlusMinus.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlusMinus.Location = new System.Drawing.Point(188, 371);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(70, 61);
            this.btnPlusMinus.TabIndex = 32;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(5, 294);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 61);
            this.btn1.TabIndex = 31;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(96, 294);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 61);
            this.btn2.TabIndex = 30;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(187, 295);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 61);
            this.btn3.TabIndex = 29;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(6, 218);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 61);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(97, 218);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 61);
            this.btn5.TabIndex = 27;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(188, 219);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 61);
            this.btn6.TabIndex = 26;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(6, 142);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 61);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(96, 142);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 61);
            this.btn8.TabIndex = 24;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDarkMode.Location = new System.Drawing.Point(340, 111);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(87, 16);
            this.chkDarkMode.TabIndex = 5;
            this.chkDarkMode.Text = "&Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // rdoScientfic
            // 
            this.rdoScientfic.AutoSize = true;
            this.rdoScientfic.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoScientfic.Location = new System.Drawing.Point(175, 111);
            this.rdoScientfic.Name = "rdoScientfic";
            this.rdoScientfic.Size = new System.Drawing.Size(93, 16);
            this.rdoScientfic.TabIndex = 4;
            this.rdoScientfic.Text = "Scie&ntific";
            this.rdoScientfic.UseVisualStyleBackColor = true;
            this.rdoScientfic.CheckedChanged += new System.EventHandler(this.rdoScientfic_CheckedChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Lucida Console", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(14, 25);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(602, 42);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoStandard.Location = new System.Drawing.Point(24, 111);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(79, 16);
            this.rdoStandard.TabIndex = 2;
            this.rdoStandard.Text = "&Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            this.rdoStandard.CheckedChanged += new System.EventHandler(this.rdoStandard_CheckedChanged);
            // 
            // tabApp
            // 
            this.tabApp.Controls.Add(this.tpCalculator);
            this.tabApp.Controls.Add(this.tpAboutMe);
            this.tabApp.Location = new System.Drawing.Point(0, 0);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(635, 461);
            this.tabApp.TabIndex = 1;
            this.tabApp.Click += new System.EventHandler(this.AboutMe_Click);
            // 
            // tpCalculator
            // 
            this.tpCalculator.BackColor = System.Drawing.Color.Transparent;
            this.tpCalculator.Controls.Add(this.btn1x);
            this.tpCalculator.Controls.Add(this.lblStep);
            this.tpCalculator.Controls.Add(this.btnBS);
            this.tpCalculator.Controls.Add(this.lblModel);
            this.tpCalculator.Controls.Add(this.btnLuckyNum);
            this.tpCalculator.Controls.Add(this.btnPi);
            this.tpCalculator.Controls.Add(this.btnXSquareY);
            this.tpCalculator.Controls.Add(this.btnTan);
            this.tpCalculator.Controls.Add(this.btnCos);
            this.tpCalculator.Controls.Add(this.btnSine);
            this.tpCalculator.Controls.Add(this.btnFactorial);
            this.tpCalculator.Controls.Add(this.btnSquare);
            this.tpCalculator.Controls.Add(this.btnRoot);
            this.tpCalculator.Controls.Add(this.btnEqual);
            this.tpCalculator.Controls.Add(this.btnDivide);
            this.tpCalculator.Controls.Add(this.btnMultiply);
            this.tpCalculator.Controls.Add(this.btnSubtract);
            this.tpCalculator.Controls.Add(this.btnAdd);
            this.tpCalculator.Controls.Add(this.btnClear);
            this.tpCalculator.Controls.Add(this.btn0);
            this.tpCalculator.Controls.Add(this.btnPoint);
            this.tpCalculator.Controls.Add(this.btnPlusMinus);
            this.tpCalculator.Controls.Add(this.btn1);
            this.tpCalculator.Controls.Add(this.btn2);
            this.tpCalculator.Controls.Add(this.btn3);
            this.tpCalculator.Controls.Add(this.btn4);
            this.tpCalculator.Controls.Add(this.btn5);
            this.tpCalculator.Controls.Add(this.btn6);
            this.tpCalculator.Controls.Add(this.btn7);
            this.tpCalculator.Controls.Add(this.btn8);
            this.tpCalculator.Controls.Add(this.btn9);
            this.tpCalculator.Controls.Add(this.chkDarkMode);
            this.tpCalculator.Controls.Add(this.rdoScientfic);
            this.tpCalculator.Controls.Add(this.txtResult);
            this.tpCalculator.Controls.Add(this.rdoStandard);
            this.tpCalculator.Location = new System.Drawing.Point(4, 24);
            this.tpCalculator.Name = "tpCalculator";
            this.tpCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalculator.Size = new System.Drawing.Size(627, 433);
            this.tpCalculator.TabIndex = 0;
            this.tpCalculator.Text = "Calculator";
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.Color.SlateGray;
            this.btn1x.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1x.Location = new System.Drawing.Point(264, 373);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(59, 61);
            this.btn1x.TabIndex = 53;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStep.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStep.Location = new System.Drawing.Point(24, 70);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(0, 19);
            this.lblStep.TabIndex = 52;
            // 
            // btnBS
            // 
            this.btnBS.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBS.Location = new System.Drawing.Point(369, 142);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(70, 61);
            this.btnBS.TabIndex = 51;
            this.btnBS.Text = "&BS";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.ForeColor = System.Drawing.Color.Red;
            this.lblModel.Location = new System.Drawing.Point(460, 101);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(156, 27);
            this.lblModel.TabIndex = 50;
            this.lblModel.Text = "HAL 10000";
            this.lblModel.Click += new System.EventHandler(this.lblModel_Click);
            // 
            // btnLuckyNum
            // 
            this.btnLuckyNum.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLuckyNum.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLuckyNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuckyNum.Location = new System.Drawing.Point(546, 371);
            this.btnLuckyNum.Name = "btnLuckyNum";
            this.btnLuckyNum.Size = new System.Drawing.Size(70, 61);
            this.btnLuckyNum.TabIndex = 49;
            this.btnLuckyNum.Text = "??";
            this.btnLuckyNum.UseVisualStyleBackColor = false;
            this.btnLuckyNum.Click += new System.EventHandler(this.btnLuckyNum_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPi.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPi.Location = new System.Drawing.Point(460, 371);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(70, 61);
            this.btnPi.TabIndex = 48;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnXSquareY
            // 
            this.btnXSquareY.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXSquareY.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXSquareY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXSquareY.Location = new System.Drawing.Point(546, 295);
            this.btnXSquareY.Name = "btnXSquareY";
            this.btnXSquareY.Size = new System.Drawing.Size(70, 61);
            this.btnXSquareY.TabIndex = 47;
            this.btnXSquareY.Text = "^";
            this.btnXSquareY.UseVisualStyleBackColor = false;
            this.btnXSquareY.Click += new System.EventHandler(this.btnBasicCal_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTan.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTan.Location = new System.Drawing.Point(460, 295);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(70, 61);
            this.btnTan.TabIndex = 46;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCos.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCos.Location = new System.Drawing.Point(547, 217);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(70, 61);
            this.btnCos.TabIndex = 45;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSine
            // 
            this.btnSine.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSine.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSine.Location = new System.Drawing.Point(460, 218);
            this.btnSine.Name = "btnSine";
            this.btnSine.Size = new System.Drawing.Size(70, 61);
            this.btnSine.TabIndex = 44;
            this.btnSine.Text = "sine";
            this.btnSine.UseVisualStyleBackColor = false;
            this.btnSine.Click += new System.EventHandler(this.btnSine_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFactorial.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFactorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFactorial.Location = new System.Drawing.Point(547, 143);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(70, 61);
            this.btnFactorial.TabIndex = 43;
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSquare.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquare.Location = new System.Drawing.Point(460, 143);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(70, 61);
            this.btnSquare.TabIndex = 42;
            this.btnSquare.Text = "^2";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(187, 143);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 61);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // tpAboutMe
            // 
            this.tpAboutMe.BackColor = System.Drawing.Color.Silver;
            this.tpAboutMe.Controls.Add(this.picWinter);
            this.tpAboutMe.Controls.Add(this.rdoWinter);
            this.tpAboutMe.Controls.Add(this.rdoSummer);
            this.tpAboutMe.Controls.Add(this.textBox1);
            this.tpAboutMe.Controls.Add(this.picSummer);
            this.tpAboutMe.Controls.Add(this.picLogo);
            this.tpAboutMe.Location = new System.Drawing.Point(4, 24);
            this.tpAboutMe.Name = "tpAboutMe";
            this.tpAboutMe.Padding = new System.Windows.Forms.Padding(3);
            this.tpAboutMe.Size = new System.Drawing.Size(627, 433);
            this.tpAboutMe.TabIndex = 1;
            this.tpAboutMe.Text = "About Me";
            // 
            // picWinter
            // 
            this.picWinter.Image = ((System.Drawing.Image)(resources.GetObject("picWinter.Image")));
            this.picWinter.Location = new System.Drawing.Point(0, 0);
            this.picWinter.Name = "picWinter";
            this.picWinter.Size = new System.Drawing.Size(451, 296);
            this.picWinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWinter.TabIndex = 5;
            this.picWinter.TabStop = false;
            this.picWinter.Visible = false;
            // 
            // rdoWinter
            // 
            this.rdoWinter.AutoSize = true;
            this.rdoWinter.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoWinter.Location = new System.Drawing.Point(253, 363);
            this.rdoWinter.Name = "rdoWinter";
            this.rdoWinter.Size = new System.Drawing.Size(135, 15);
            this.rdoWinter.TabIndex = 4;
            this.rdoWinter.TabStop = true;
            this.rdoWinter.Text = "Winter In Canada";
            this.rdoWinter.UseVisualStyleBackColor = true;
            this.rdoWinter.CheckedChanged += new System.EventHandler(this.rdoWinter_CheckedChanged);
            // 
            // rdoSummer
            // 
            this.rdoSummer.AutoSize = true;
            this.rdoSummer.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoSummer.Location = new System.Drawing.Point(253, 342);
            this.rdoSummer.Name = "rdoSummer";
            this.rdoSummer.Size = new System.Drawing.Size(156, 15);
            this.rdoSummer.TabIndex = 3;
            this.rdoSummer.TabStop = true;
            this.rdoSummer.Text = "Summer In Hong Kong";
            this.rdoSummer.UseVisualStyleBackColor = true;
            this.rdoSummer.CheckedChanged += new System.EventHandler(this.rdoSummer_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Don\'t believe in luck. Believe in practice";
            // 
            // picSummer
            // 
            this.picSummer.Image = ((System.Drawing.Image)(resources.GetObject("picSummer.Image")));
            this.picSummer.Location = new System.Drawing.Point(0, 0);
            this.picSummer.Name = "picSummer";
            this.picSummer.Size = new System.Drawing.Size(451, 296);
            this.picSummer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSummer.TabIndex = 1;
            this.picSummer.TabStop = false;
            this.picSummer.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 293);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(225, 115);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // formCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 461);
            this.Controls.Add(this.tabApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ka Wai Calculator";
            this.tabApp.ResumeLayout(false);
            this.tpCalculator.ResumeLayout(false);
            this.tpCalculator.PerformLayout();
            this.tpAboutMe.ResumeLayout(false);
            this.tpAboutMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRoot;
        private Button btnEqual;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnClear;
        private Button btn0;
        private Button btnPoint;
        private Button btnPlusMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private CheckBox chkDarkMode;
        private RadioButton rdoScientfic;
        private TextBox txtResult;
        private RadioButton rdoStandard;
        private TabControl tabApp;
        private TabPage tpCalculator;
        private Button btn9;
        private TabPage tpAboutMe;
        private Button btnLuckyNum;
        private Button btnPi;
        private Button btnXSquareY;
        private Button btnTan;
        private Button btnCos;
        private Button btnSine;
        private Button btnFactorial;
        private Button btnSquare;
        private Label lblModel;
        private Button btnBS;
        private Label lblStep;
        private PictureBox picLogo;
        private TextBox textBox1;
        private PictureBox picSummer;
        private PictureBox picWinter;
        private RadioButton rdoWinter;
        private RadioButton rdoSummer;
        private Button btn1x;
    }
}