namespace MTSS
{
    partial class MTSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTSS));
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.chkBxMath = new System.Windows.Forms.CheckBox();
            this.chkBxReading = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(12, 53);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 0;
            this.txtBxFirstName.TextChanged += new System.EventHandler(this.txtBxFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(12, 96);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 3;
            this.txtBxLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rtbNotes
            // 
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotes.Location = new System.Drawing.Point(299, 53);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(285, 126);
            this.rtbNotes.TabIndex = 4;
            this.rtbNotes.Text = "";
            this.rtbNotes.TextChanged += new System.EventHandler(this.rtbNotes_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(299, 34);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(18, 123);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Grade";
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbGrade.Location = new System.Drawing.Point(12, 139);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(42, 21);
            this.cbGrade.TabIndex = 7;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // chkBxMath
            // 
            this.chkBxMath.AutoSize = true;
            this.chkBxMath.Location = new System.Drawing.Point(15, 212);
            this.chkBxMath.Name = "chkBxMath";
            this.chkBxMath.Size = new System.Drawing.Size(50, 17);
            this.chkBxMath.TabIndex = 8;
            this.chkBxMath.Text = "Math";
            this.chkBxMath.UseVisualStyleBackColor = true;
            this.chkBxMath.CheckedChanged += new System.EventHandler(this.chkBxMath_CheckedChanged);
            // 
            // chkBxReading
            // 
            this.chkBxReading.AutoSize = true;
            this.chkBxReading.Location = new System.Drawing.Point(120, 212);
            this.chkBxReading.Name = "chkBxReading";
            this.chkBxReading.Size = new System.Drawing.Size(66, 17);
            this.chkBxReading.TabIndex = 9;
            this.chkBxReading.Text = "Reading";
            this.chkBxReading.UseVisualStyleBackColor = true;
            this.chkBxReading.CheckedChanged += new System.EventHandler(this.chkBxReading_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "Open";
            // 
            // MTSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkBxReading);
            this.Controls.Add(this.chkBxMath);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBxFirstName);
            this.Name = "MTSS";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.CheckBox chkBxMath;
        private System.Windows.Forms.CheckBox chkBxReading;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbOpen;
    }
}

