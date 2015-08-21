namespace AnalogClockProject
{
    partial class AnalogClockForm
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
            this.components = new System.ComponentModel.Container();
            this.cTimer = new System.Windows.Forms.Timer(this.components);
            this.timeBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbMilitaryTime = new System.Windows.Forms.CheckBox();
            this.lblTimeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cTimer
            // 
            this.cTimer.Enabled = true;
            this.cTimer.Tick += new System.EventHandler(this.cTimer_Tick);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(0, 0);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(68, 20);
            this.timeBox.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 53);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // cbMilitaryTime
            // 
            this.cbMilitaryTime.AutoSize = true;
            this.cbMilitaryTime.Location = new System.Drawing.Point(251, 313);
            this.cbMilitaryTime.Name = "cbMilitaryTime";
            this.cbMilitaryTime.Size = new System.Drawing.Size(84, 17);
            this.cbMilitaryTime.TabIndex = 2;
            this.cbMilitaryTime.Text = "Military Time";
            this.cbMilitaryTime.UseVisualStyleBackColor = true;
            // 
            // lblTimeBox
            // 
            this.lblTimeBox.AutoSize = true;
            this.lblTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeBox.Location = new System.Drawing.Point(81, 224);
            this.lblTimeBox.Name = "lblTimeBox";
            this.lblTimeBox.Size = new System.Drawing.Size(51, 20);
            this.lblTimeBox.TabIndex = 3;
            this.lblTimeBox.Text = "label1";
            // 
            // AnalogClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblTimeBox);
            this.Controls.Add(this.cbMilitaryTime);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.timeBox);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "AnalogClockForm";
            this.Text = "AnalogClock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer cTimer;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox cbMilitaryTime;
        private System.Windows.Forms.Label lblTimeBox;
    }
}

