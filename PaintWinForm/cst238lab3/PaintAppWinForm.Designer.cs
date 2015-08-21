namespace PaintAppWinForm
{
    partial class formLab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLab3));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlViewMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.imgSelect = new System.Windows.Forms.PictureBox();
            this.imgBrush = new System.Windows.Forms.PictureBox();
            this.imgPencil = new System.Windows.Forms.PictureBox();
            this.imgLines = new System.Windows.Forms.PictureBox();
            this.imgText = new System.Windows.Forms.PictureBox();
            this.imgEraser = new System.Windows.Forms.PictureBox();
            this.viewMenu = new System.Windows.Forms.Label();
            this.imageMenu = new System.Windows.Forms.Label();
            this.pnlImageMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.imgFlipVert = new System.Windows.Forms.PictureBox();
            this.imgFlipHoriz = new System.Windows.Forms.PictureBox();
            this.imgRotate90 = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorMenu = new System.Windows.Forms.Label();
            this.pnlShapes = new System.Windows.Forms.Panel();
            this.pbHexagon = new System.Windows.Forms.PictureBox();
            this.pbPentagon = new System.Windows.Forms.PictureBox();
            this.pbRectangle = new System.Windows.Forms.PictureBox();
            this.pbEllipse = new System.Windows.Forms.PictureBox();
            this.pbBezier = new System.Windows.Forms.PictureBox();
            this.pbLine = new System.Windows.Forms.PictureBox();
            this.clearMenu = new System.Windows.Forms.Label();
            this.saveMenu = new System.Windows.Forms.Label();
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.pnlViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEraser)).BeginInit();
            this.pnlImageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlipVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlipHoriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRotate90)).BeginInit();
            this.pnlShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHexagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPentagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBezier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusBar
            // 
            this.tsStatusBar.Name = "tsStatusBar";
            this.tsStatusBar.Size = new System.Drawing.Size(39, 17);
            this.tsStatusBar.Text = "Pencil";
            // 
            // pnlViewMenu
            // 
            this.pnlViewMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewMenu.BackColor = System.Drawing.Color.LightCyan;
            this.pnlViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlViewMenu.Controls.Add(this.imgSelect);
            this.pnlViewMenu.Controls.Add(this.imgBrush);
            this.pnlViewMenu.Controls.Add(this.imgPencil);
            this.pnlViewMenu.Controls.Add(this.imgLines);
            this.pnlViewMenu.Controls.Add(this.imgText);
            this.pnlViewMenu.Controls.Add(this.imgEraser);
            this.pnlViewMenu.Location = new System.Drawing.Point(15, 44);
            this.pnlViewMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlViewMenu.Name = "pnlViewMenu";
            this.pnlViewMenu.Size = new System.Drawing.Size(760, 32);
            this.pnlViewMenu.TabIndex = 1;
            // 
            // imgSelect
            // 
            this.imgSelect.BackColor = System.Drawing.Color.Transparent;
            this.imgSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSelect.Image = ((System.Drawing.Image)(resources.GetObject("imgSelect.Image")));
            this.imgSelect.Location = new System.Drawing.Point(3, 3);
            this.imgSelect.Name = "imgSelect";
            this.imgSelect.Size = new System.Drawing.Size(23, 23);
            this.imgSelect.TabIndex = 8;
            this.imgSelect.TabStop = false;
            this.imgSelect.Click += new System.EventHandler(this.viewMenu_Click);
            this.imgSelect.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            // 
            // imgBrush
            // 
            this.imgBrush.BackColor = System.Drawing.Color.Transparent;
            this.imgBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBrush.Image = ((System.Drawing.Image)(resources.GetObject("imgBrush.Image")));
            this.imgBrush.Location = new System.Drawing.Point(32, 3);
            this.imgBrush.Name = "imgBrush";
            this.imgBrush.Size = new System.Drawing.Size(23, 23);
            this.imgBrush.TabIndex = 5;
            this.imgBrush.TabStop = false;
            this.imgBrush.Click += new System.EventHandler(this.viewMenu_Click);
            this.imgBrush.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            // 
            // imgPencil
            // 
            this.imgPencil.BackColor = System.Drawing.Color.Transparent;
            this.imgPencil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPencil.Image = ((System.Drawing.Image)(resources.GetObject("imgPencil.Image")));
            this.imgPencil.Location = new System.Drawing.Point(61, 3);
            this.imgPencil.Name = "imgPencil";
            this.imgPencil.Size = new System.Drawing.Size(23, 23);
            this.imgPencil.TabIndex = 4;
            this.imgPencil.TabStop = false;
            this.imgPencil.Click += new System.EventHandler(this.viewMenu_Click);
            this.imgPencil.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            // 
            // imgLines
            // 
            this.imgLines.BackColor = System.Drawing.Color.Transparent;
            this.imgLines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLines.Image = ((System.Drawing.Image)(resources.GetObject("imgLines.Image")));
            this.imgLines.Location = new System.Drawing.Point(90, 3);
            this.imgLines.Name = "imgLines";
            this.imgLines.Size = new System.Drawing.Size(23, 23);
            this.imgLines.TabIndex = 6;
            this.imgLines.TabStop = false;
            this.imgLines.Click += new System.EventHandler(this.viewMenu_Click);
            this.imgLines.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            // 
            // imgText
            // 
            this.imgText.BackColor = System.Drawing.Color.Transparent;
            this.imgText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgText.Image = ((System.Drawing.Image)(resources.GetObject("imgText.Image")));
            this.imgText.Location = new System.Drawing.Point(119, 3);
            this.imgText.Name = "imgText";
            this.imgText.Size = new System.Drawing.Size(23, 23);
            this.imgText.TabIndex = 7;
            this.imgText.TabStop = false;
            this.imgText.Click += new System.EventHandler(this.viewMenu_Click);
            this.imgText.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            // 
            // imgEraser
            // 
            this.imgEraser.BackColor = System.Drawing.Color.Transparent;
            this.imgEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEraser.Image = ((System.Drawing.Image)(resources.GetObject("imgEraser.Image")));
            this.imgEraser.Location = new System.Drawing.Point(148, 3);
            this.imgEraser.Name = "imgEraser";
            this.imgEraser.Size = new System.Drawing.Size(23, 23);
            this.imgEraser.TabIndex = 9;
            this.imgEraser.TabStop = false;
            this.imgEraser.Click += new System.EventHandler(this.viewMenu_Click);
            this.imgEraser.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            // 
            // viewMenu
            // 
            this.viewMenu.AutoSize = true;
            this.viewMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenu.Location = new System.Drawing.Point(15, 13);
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(45, 22);
            this.viewMenu.TabIndex = 2;
            this.viewMenu.Text = "View";
            this.viewMenu.Click += new System.EventHandler(this.topMenu_Click);
            // 
            // imageMenu
            // 
            this.imageMenu.AutoSize = true;
            this.imageMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageMenu.Location = new System.Drawing.Point(67, 13);
            this.imageMenu.Name = "imageMenu";
            this.imageMenu.Size = new System.Drawing.Size(54, 20);
            this.imageMenu.TabIndex = 3;
            this.imageMenu.Text = "Image";
            this.imageMenu.Click += new System.EventHandler(this.topMenu_Click);
            // 
            // pnlImageMenu
            // 
            this.pnlImageMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImageMenu.BackColor = System.Drawing.Color.LightCyan;
            this.pnlImageMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlImageMenu.Controls.Add(this.imgFlipVert);
            this.pnlImageMenu.Controls.Add(this.imgFlipHoriz);
            this.pnlImageMenu.Controls.Add(this.imgRotate90);
            this.pnlImageMenu.Location = new System.Drawing.Point(15, 44);
            this.pnlImageMenu.Name = "pnlImageMenu";
            this.pnlImageMenu.Size = new System.Drawing.Size(760, 32);
            this.pnlImageMenu.TabIndex = 9;
            this.pnlImageMenu.Visible = false;
            // 
            // imgFlipVert
            // 
            this.imgFlipVert.BackColor = System.Drawing.Color.White;
            this.imgFlipVert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFlipVert.Image = ((System.Drawing.Image)(resources.GetObject("imgFlipVert.Image")));
            this.imgFlipVert.Location = new System.Drawing.Point(3, 3);
            this.imgFlipVert.Name = "imgFlipVert";
            this.imgFlipVert.Size = new System.Drawing.Size(23, 23);
            this.imgFlipVert.TabIndex = 0;
            this.imgFlipVert.TabStop = false;
            this.imgFlipVert.Click += new System.EventHandler(this.imageMenu_Click);
            this.imgFlipVert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageMenuPanel_MouseDown);
            this.imgFlipVert.MouseLeave += new System.EventHandler(this.imageMenuPanel_MouseLeave);
            this.imgFlipVert.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            this.imgFlipVert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageMenuPanel_MouseUp);
            // 
            // imgFlipHoriz
            // 
            this.imgFlipHoriz.BackColor = System.Drawing.Color.White;
            this.imgFlipHoriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFlipHoriz.Image = ((System.Drawing.Image)(resources.GetObject("imgFlipHoriz.Image")));
            this.imgFlipHoriz.Location = new System.Drawing.Point(32, 3);
            this.imgFlipHoriz.Name = "imgFlipHoriz";
            this.imgFlipHoriz.Size = new System.Drawing.Size(23, 23);
            this.imgFlipHoriz.TabIndex = 1;
            this.imgFlipHoriz.TabStop = false;
            this.imgFlipHoriz.Click += new System.EventHandler(this.imageMenu_Click);
            this.imgFlipHoriz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageMenuPanel_MouseDown);
            this.imgFlipHoriz.MouseLeave += new System.EventHandler(this.imageMenuPanel_MouseLeave);
            this.imgFlipHoriz.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            this.imgFlipHoriz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageMenuPanel_MouseUp);
            // 
            // imgRotate90
            // 
            this.imgRotate90.BackColor = System.Drawing.Color.White;
            this.imgRotate90.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRotate90.Image = ((System.Drawing.Image)(resources.GetObject("imgRotate90.Image")));
            this.imgRotate90.Location = new System.Drawing.Point(61, 3);
            this.imgRotate90.Name = "imgRotate90";
            this.imgRotate90.Size = new System.Drawing.Size(23, 23);
            this.imgRotate90.TabIndex = 2;
            this.imgRotate90.TabStop = false;
            this.imgRotate90.Click += new System.EventHandler(this.imageMenu_Click);
            this.imgRotate90.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageMenuPanel_MouseDown);
            this.imgRotate90.MouseLeave += new System.EventHandler(this.imageMenuPanel_MouseLeave);
            this.imgRotate90.MouseHover += new System.EventHandler(this.iconMenu_MouseHover);
            this.imgRotate90.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageMenuPanel_MouseUp);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // colorMenu
            // 
            this.colorMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorMenu.AutoSize = true;
            this.colorMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorMenu.Location = new System.Drawing.Point(726, 13);
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(46, 20);
            this.colorMenu.TabIndex = 11;
            this.colorMenu.Text = "Color";
            this.colorMenu.Click += new System.EventHandler(this.topMenu_Click);
            this.colorMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseDown);
            this.colorMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseUp);
            // 
            // pnlShapes
            // 
            this.pnlShapes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShapes.Controls.Add(this.pbHexagon);
            this.pnlShapes.Controls.Add(this.pbPentagon);
            this.pnlShapes.Controls.Add(this.pbRectangle);
            this.pnlShapes.Controls.Add(this.pbEllipse);
            this.pnlShapes.Controls.Add(this.pbBezier);
            this.pnlShapes.Controls.Add(this.pbLine);
            this.pnlShapes.Location = new System.Drawing.Point(136, 4);
            this.pnlShapes.Name = "pnlShapes";
            this.pnlShapes.Size = new System.Drawing.Size(108, 82);
            this.pnlShapes.TabIndex = 0;
            this.pnlShapes.Visible = false;
            // 
            // pbHexagon
            // 
            this.pbHexagon.BackColor = System.Drawing.Color.Transparent;
            this.pbHexagon.Image = ((System.Drawing.Image)(resources.GetObject("pbHexagon.Image")));
            this.pbHexagon.Location = new System.Drawing.Point(71, 43);
            this.pbHexagon.Name = "pbHexagon";
            this.pbHexagon.Size = new System.Drawing.Size(23, 23);
            this.pbHexagon.TabIndex = 6;
            this.pbHexagon.TabStop = false;
            this.pbHexagon.Click += new System.EventHandler(this.pbShapes_Click);
            // 
            // pbPentagon
            // 
            this.pbPentagon.BackColor = System.Drawing.Color.Transparent;
            this.pbPentagon.Image = ((System.Drawing.Image)(resources.GetObject("pbPentagon.Image")));
            this.pbPentagon.Location = new System.Drawing.Point(42, 43);
            this.pbPentagon.Name = "pbPentagon";
            this.pbPentagon.Size = new System.Drawing.Size(23, 23);
            this.pbPentagon.TabIndex = 5;
            this.pbPentagon.TabStop = false;
            this.pbPentagon.Click += new System.EventHandler(this.pbShapes_Click);
            // 
            // pbRectangle
            // 
            this.pbRectangle.BackColor = System.Drawing.Color.Transparent;
            this.pbRectangle.Image = ((System.Drawing.Image)(resources.GetObject("pbRectangle.Image")));
            this.pbRectangle.Location = new System.Drawing.Point(13, 43);
            this.pbRectangle.Name = "pbRectangle";
            this.pbRectangle.Size = new System.Drawing.Size(23, 23);
            this.pbRectangle.TabIndex = 4;
            this.pbRectangle.TabStop = false;
            this.pbRectangle.Click += new System.EventHandler(this.pbShapes_Click);
            // 
            // pbEllipse
            // 
            this.pbEllipse.BackColor = System.Drawing.Color.Transparent;
            this.pbEllipse.Image = ((System.Drawing.Image)(resources.GetObject("pbEllipse.Image")));
            this.pbEllipse.Location = new System.Drawing.Point(71, 14);
            this.pbEllipse.Name = "pbEllipse";
            this.pbEllipse.Size = new System.Drawing.Size(23, 23);
            this.pbEllipse.TabIndex = 3;
            this.pbEllipse.TabStop = false;
            this.pbEllipse.Click += new System.EventHandler(this.pbShapes_Click);
            // 
            // pbBezier
            // 
            this.pbBezier.BackColor = System.Drawing.Color.Transparent;
            this.pbBezier.Image = ((System.Drawing.Image)(resources.GetObject("pbBezier.Image")));
            this.pbBezier.Location = new System.Drawing.Point(42, 14);
            this.pbBezier.Name = "pbBezier";
            this.pbBezier.Size = new System.Drawing.Size(23, 23);
            this.pbBezier.TabIndex = 1;
            this.pbBezier.TabStop = false;
            this.pbBezier.Click += new System.EventHandler(this.pbShapes_Click);
            // 
            // pbLine
            // 
            this.pbLine.BackColor = System.Drawing.Color.Transparent;
            this.pbLine.Image = ((System.Drawing.Image)(resources.GetObject("pbLine.Image")));
            this.pbLine.Location = new System.Drawing.Point(13, 14);
            this.pbLine.Name = "pbLine";
            this.pbLine.Size = new System.Drawing.Size(23, 23);
            this.pbLine.TabIndex = 0;
            this.pbLine.TabStop = false;
            this.pbLine.Click += new System.EventHandler(this.pbShapes_Click);
            // 
            // clearMenu
            // 
            this.clearMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearMenu.AutoSize = true;
            this.clearMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearMenu.Location = new System.Drawing.Point(623, 13);
            this.clearMenu.Name = "clearMenu";
            this.clearMenu.Size = new System.Drawing.Size(46, 20);
            this.clearMenu.TabIndex = 12;
            this.clearMenu.Text = "Clear";
            this.clearMenu.Click += new System.EventHandler(this.topMenu_Click);
            this.clearMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseDown);
            this.clearMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseUp);
            // 
            // saveMenu
            // 
            this.saveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveMenu.AutoSize = true;
            this.saveMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMenu.Location = new System.Drawing.Point(675, 13);
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(45, 20);
            this.saveMenu.TabIndex = 13;
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.topMenu_Click);
            this.saveMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseDown);
            this.saveMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseUp);
            // 
            // pbDraw
            // 
            this.pbDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDraw.BackColor = System.Drawing.Color.White;
            this.pbDraw.Location = new System.Drawing.Point(15, 82);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(760, 444);
            this.pbDraw.TabIndex = 0;
            this.pbDraw.TabStop = false;
            this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseDown);
            this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseMove);
            this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseUp);
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.Location = new System.Drawing.Point(452, 15);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(100, 26);
            this.tbText.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Submit";
            this.label1.Click += new System.EventHandler(this.topMenu_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clickMenu_MouseUp);
            // 
            // formLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveMenu);
            this.Controls.Add(this.clearMenu);
            this.Controls.Add(this.pnlShapes);
            this.Controls.Add(this.colorMenu);
            this.Controls.Add(this.pnlViewMenu);
            this.Controls.Add(this.imageMenu);
            this.Controls.Add(this.pbDraw);
            this.Controls.Add(this.viewMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlImageMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "formLab3";
            this.Text = "Anthony\'s Paint";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEraser)).EndInit();
            this.pnlImageMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFlipVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlipHoriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRotate90)).EndInit();
            this.pnlShapes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHexagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPentagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBezier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusBar;
        private System.Windows.Forms.FlowLayoutPanel pnlViewMenu;
        private System.Windows.Forms.Label viewMenu;
        private System.Windows.Forms.Label imageMenu;
        private System.Windows.Forms.PictureBox imgPencil;
        private System.Windows.Forms.PictureBox imgBrush;
        private System.Windows.Forms.PictureBox imgLines;
        private System.Windows.Forms.PictureBox imgText;
        private System.Windows.Forms.PictureBox imgSelect;
        private System.Windows.Forms.FlowLayoutPanel pnlImageMenu;
        private System.Windows.Forms.PictureBox imgFlipVert;
        private System.Windows.Forms.PictureBox imgFlipHoriz;
        private System.Windows.Forms.PictureBox imgRotate90;
        private System.Windows.Forms.PictureBox imgEraser;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label colorMenu;
        private System.Windows.Forms.Panel pnlShapes;
        private System.Windows.Forms.PictureBox pbHexagon;
        private System.Windows.Forms.PictureBox pbPentagon;
        private System.Windows.Forms.PictureBox pbRectangle;
        private System.Windows.Forms.PictureBox pbEllipse;
        private System.Windows.Forms.PictureBox pbBezier;
        private System.Windows.Forms.PictureBox pbLine;
        private System.Windows.Forms.Label clearMenu;
        private System.Windows.Forms.Label saveMenu;
        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;



    }
}

