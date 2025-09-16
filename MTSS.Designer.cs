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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTSS));
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.chkBxMath = new System.Windows.Forms.CheckBox();
            this.chkBxReading = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tmrNoName = new System.Windows.Forms.Timer(this.components);
            this.lblNoName = new System.Windows.Forms.Label();
            this.checkBoxMath = new System.Windows.Forms.CheckedListBox();
            this.checkBoxReading = new System.Windows.Forms.CheckedListBox();
            this.txtBxNotes = new System.Windows.Forms.TextBox();
            this.btnScores = new System.Windows.Forms.Button();
            this.calSchedule = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.chkBxMath.Location = new System.Drawing.Point(12, 179);
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
            this.chkBxReading.Location = new System.Drawing.Point(12, 272);
            this.chkBxReading.Name = "chkBxReading";
            this.chkBxReading.Size = new System.Drawing.Size(66, 17);
            this.chkBxReading.TabIndex = 9;
            this.chkBxReading.Text = "Reading";
            this.chkBxReading.UseVisualStyleBackColor = true;
            this.chkBxReading.CheckedChanged += new System.EventHandler(this.chkBxReading_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 25);
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
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tmrNoName
            // 
            this.tmrNoName.Interval = 3000;
            this.tmrNoName.Tick += new System.EventHandler(this.tmrNoName_Tick);
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(9, 21);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(224, 13);
            this.lblNoName.TabIndex = 11;
            this.lblNoName.Text = "Please add a first and last name before saving";
            this.lblNoName.Visible = false;
            // 
            // checkBoxMath
            // 
            this.checkBoxMath.CheckOnClick = true;
            this.checkBoxMath.Enabled = false;
            this.checkBoxMath.FormattingEnabled = true;
            this.checkBoxMath.Items.AddRange(new object[] {
            "Number Sense",
            "Fact Fluency",
            "Problem Solving",
            "Mathematical Language"});
            this.checkBoxMath.Location = new System.Drawing.Point(12, 202);
            this.checkBoxMath.Name = "checkBoxMath";
            this.checkBoxMath.Size = new System.Drawing.Size(139, 64);
            this.checkBoxMath.TabIndex = 12;
            this.checkBoxMath.SelectedIndexChanged += new System.EventHandler(this.checkBoxMath_SelectedIndexChanged);
            // 
            // checkBoxReading
            // 
            this.checkBoxReading.CheckOnClick = true;
            this.checkBoxReading.Enabled = false;
            this.checkBoxReading.FormattingEnabled = true;
            this.checkBoxReading.Items.AddRange(new object[] {
            "Phonics",
            "Fluency",
            "Comprehension",
            "Vocab",
            "Phonic Awareness"});
            this.checkBoxReading.Location = new System.Drawing.Point(12, 296);
            this.checkBoxReading.Name = "checkBoxReading";
            this.checkBoxReading.Size = new System.Drawing.Size(139, 79);
            this.checkBoxReading.TabIndex = 13;
            this.checkBoxReading.SelectedIndexChanged += new System.EventHandler(this.checkBoxReading_SelectedIndexChanged);
            // 
            // txtBxNotes
            // 
            this.txtBxNotes.Location = new System.Drawing.Point(302, 53);
            this.txtBxNotes.Multiline = true;
            this.txtBxNotes.Name = "txtBxNotes";
            this.txtBxNotes.Size = new System.Drawing.Size(296, 127);
            this.txtBxNotes.TabIndex = 14;
            this.txtBxNotes.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(12, 381);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(139, 23);
            this.btnScores.TabIndex = 15;
            this.btnScores.Text = "Subject Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // calSchedule
            // 
            this.calSchedule.Location = new System.Drawing.Point(302, 213);
            this.calSchedule.Name = "calSchedule";
            this.calSchedule.TabIndex = 16;
            this.calSchedule.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calSchedule_DateSelected);
            // 
            // MTSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 411);
            this.Controls.Add(this.calSchedule);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.txtBxNotes);
            this.Controls.Add(this.checkBoxReading);
            this.Controls.Add(this.checkBoxMath);
            this.Controls.Add(this.lblNoName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkBxReading);
            this.Controls.Add(this.chkBxMath);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBxFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MTSS";
            this.Text = "MTSS";
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
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.CheckBox chkBxMath;
        private System.Windows.Forms.CheckBox chkBxReading;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.Timer tmrNoName;
        private System.Windows.Forms.Label lblNoName;
        private System.Windows.Forms.CheckedListBox checkBoxMath;
        private System.Windows.Forms.CheckedListBox checkBoxReading;
        private System.Windows.Forms.TextBox txtBxNotes;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.MonthCalendar calSchedule;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

