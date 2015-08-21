namespace cst238lab2
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitGroupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnC = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.mathText = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblStoreNumber = new System.Windows.Forms.Label();
            this.btnRightParen = new System.Windows.Forms.Button();
            this.btnLeftParen = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(302, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip1";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.menuToolStripMenuItem.Text = "Edit";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.digitGroupingToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.optionsToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // digitGroupingToolStripMenuItem
            // 
            this.digitGroupingToolStripMenuItem.Name = "digitGroupingToolStripMenuItem";
            this.digitGroupingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.digitGroupingToolStripMenuItem.Text = "Digit Grouping";
            this.digitGroupingToolStripMenuItem.Click += new System.EventHandler(this.digitGroupingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnC
            // 
            this.btnC.ForeColor = System.Drawing.Color.Red;
            this.btnC.Location = new System.Drawing.Point(241, 65);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(51, 36);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInverse.Location = new System.Drawing.Point(252, 193);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(40, 36);
            this.btnInverse.TabIndex = 4;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPercent.Location = new System.Drawing.Point(252, 149);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(40, 38);
            this.btnPercent.TabIndex = 5;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSqrt.Location = new System.Drawing.Point(252, 107);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(40, 36);
            this.btnSqrt.TabIndex = 6;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.ForeColor = System.Drawing.Color.Red;
            this.btnBackspace.Location = new System.Drawing.Point(115, 65);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(69, 36);
            this.btnBackspace.TabIndex = 7;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnCE
            // 
            this.btnCE.ForeColor = System.Drawing.Color.Red;
            this.btnCE.Location = new System.Drawing.Point(190, 65);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(51, 36);
            this.btnCE.TabIndex = 8;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // mathText
            // 
            this.mathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathText.Location = new System.Drawing.Point(14, 27);
            this.mathText.MaxLength = 30;
            this.mathText.Name = "mathText";
            this.mathText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mathText.Size = new System.Drawing.Size(276, 26);
            this.mathText.TabIndex = 9;
            this.mathText.Text = "0";
            this.mathText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEquals
            // 
            this.btnEquals.ForeColor = System.Drawing.Color.Red;
            this.btnEquals.Location = new System.Drawing.Point(252, 235);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(40, 36);
            this.btnEquals.TabIndex = 10;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(206, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(206, 107);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(40, 36);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.button_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(206, 149);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(40, 38);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.ForeColor = System.Drawing.Color.Red;
            this.btnSubtract.Location = new System.Drawing.Point(206, 193);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(40, 36);
            this.btnSubtract.TabIndex = 11;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDot
            // 
            this.btnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDot.Location = new System.Drawing.Point(160, 235);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(40, 36);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.button_Click);
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn9.Location = new System.Drawing.Point(160, 107);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 36);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn6.Location = new System.Drawing.Point(160, 149);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 38);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn3.Location = new System.Drawing.Point(160, 193);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 36);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.ForeColor = System.Drawing.Color.Red;
            this.btnMPlus.Location = new System.Drawing.Point(11, 235);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(40, 36);
            this.btnMPlus.TabIndex = 30;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMC
            // 
            this.btnMC.ForeColor = System.Drawing.Color.Red;
            this.btnMC.Location = new System.Drawing.Point(11, 107);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(40, 36);
            this.btnMC.TabIndex = 29;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.ForeColor = System.Drawing.Color.Red;
            this.btnMR.Location = new System.Drawing.Point(11, 149);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(40, 38);
            this.btnMR.TabIndex = 28;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.ForeColor = System.Drawing.Color.Red;
            this.btnMS.Location = new System.Drawing.Point(11, 193);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(40, 36);
            this.btnMS.TabIndex = 27;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn0.Location = new System.Drawing.Point(67, 235);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 36);
            this.btn0.TabIndex = 26;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_Click);
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn7.Location = new System.Drawing.Point(67, 107);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 36);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn4.Location = new System.Drawing.Point(67, 149);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 38);
            this.btn4.TabIndex = 24;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn1.Location = new System.Drawing.Point(67, 193);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 36);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSign
            // 
            this.btnSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSign.Location = new System.Drawing.Point(113, 235);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(40, 36);
            this.btnSign.TabIndex = 22;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn8.Location = new System.Drawing.Point(113, 107);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 36);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn5.Location = new System.Drawing.Point(113, 149);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 38);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2.Location = new System.Drawing.Point(113, 193);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 36);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // lblStoreNumber
            // 
            this.lblStoreNumber.AutoSize = true;
            this.lblStoreNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStoreNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStoreNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStoreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreNumber.Location = new System.Drawing.Point(14, 65);
            this.lblStoreNumber.MaximumSize = new System.Drawing.Size(35, 22);
            this.lblStoreNumber.Name = "lblStoreNumber";
            this.lblStoreNumber.Size = new System.Drawing.Size(35, 22);
            this.lblStoreNumber.TabIndex = 31;
            this.lblStoreNumber.Text = "      ";
            this.lblStoreNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRightParen
            // 
            this.btnRightParen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRightParen.Location = new System.Drawing.Point(86, 65);
            this.btnRightParen.Name = "btnRightParen";
            this.btnRightParen.Size = new System.Drawing.Size(23, 36);
            this.btnRightParen.TabIndex = 32;
            this.btnRightParen.Text = ")";
            this.btnRightParen.UseVisualStyleBackColor = true;
            this.btnRightParen.Click += new System.EventHandler(this.button_Click);
            // 
            // btnLeftParen
            // 
            this.btnLeftParen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLeftParen.Location = new System.Drawing.Point(55, 65);
            this.btnLeftParen.Name = "btnLeftParen";
            this.btnLeftParen.Size = new System.Drawing.Size(23, 36);
            this.btnLeftParen.TabIndex = 33;
            this.btnLeftParen.Text = "(";
            this.btnLeftParen.UseVisualStyleBackColor = true;
            this.btnLeftParen.Click += new System.EventHandler(this.button_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 279);
            this.Controls.Add(this.btnLeftParen);
            this.Controls.Add(this.btnRightParen);
            this.Controls.Add(this.lblStoreNumber);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.mathText);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitGroupingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.TextBox mathText;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Label lblStoreNumber;
        private System.Windows.Forms.Button btnRightParen;
        private System.Windows.Forms.Button btnLeftParen;
    }
}

