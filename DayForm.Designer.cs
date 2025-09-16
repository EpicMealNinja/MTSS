namespace MTSS
{
    partial class DayForm
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
            this.chkBxScheduleDay = new System.Windows.Forms.CheckBox();
            this.lblTutorTime = new System.Windows.Forms.Label();
            this.tckSessionLen = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tckSessionLen)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBxScheduleDay
            // 
            this.chkBxScheduleDay.AutoSize = true;
            this.chkBxScheduleDay.Location = new System.Drawing.Point(12, 29);
            this.chkBxScheduleDay.Name = "chkBxScheduleDay";
            this.chkBxScheduleDay.Size = new System.Drawing.Size(127, 17);
            this.chkBxScheduleDay.TabIndex = 0;
            this.chkBxScheduleDay.Text = "Add Day to Schedule";
            this.chkBxScheduleDay.UseVisualStyleBackColor = true;
            this.chkBxScheduleDay.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTutorTime
            // 
            this.lblTutorTime.AutoSize = true;
            this.lblTutorTime.Location = new System.Drawing.Point(146, 12);
            this.lblTutorTime.Name = "lblTutorTime";
            this.lblTutorTime.Size = new System.Drawing.Size(80, 13);
            this.lblTutorTime.TabIndex = 1;
            this.lblTutorTime.Text = "Session Length";
            // 
            // tckSessionLen
            // 
            this.tckSessionLen.Location = new System.Drawing.Point(145, 28);
            this.tckSessionLen.Name = "tckSessionLen";
            this.tckSessionLen.Size = new System.Drawing.Size(120, 20);
            this.tckSessionLen.TabIndex = 2;
            this.tckSessionLen.ValueChanged += new System.EventHandler(this.tckSessionLen_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // DayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 74);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tckSessionLen);
            this.Controls.Add(this.lblTutorTime);
            this.Controls.Add(this.chkBxScheduleDay);
            this.Name = "DayForm";
            this.Text = "DayForm";
            ((System.ComponentModel.ISupportInitialize)(this.tckSessionLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBxScheduleDay;
        private System.Windows.Forms.Label lblTutorTime;
        private System.Windows.Forms.NumericUpDown tckSessionLen;
        private System.Windows.Forms.Label lblDate;
    }
}