namespace MTSS
{
    partial class subjectScoresForm
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
            this.dataMath = new System.Windows.Forms.DataGridView();
            this.dataReading = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReading)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMath
            // 
            this.dataMath.AllowUserToAddRows = false;
            this.dataMath.AllowUserToDeleteRows = false;
            this.dataMath.AllowUserToResizeColumns = false;
            this.dataMath.AllowUserToResizeRows = false;
            this.dataMath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataMath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMath.Location = new System.Drawing.Point(12, 12);
            this.dataMath.Name = "dataMath";
            this.dataMath.Size = new System.Drawing.Size(240, 219);
            this.dataMath.TabIndex = 0;
            this.dataMath.Visible = false;
            this.dataMath.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMath_CellContentClick);
            // 
            // dataReading
            // 
            this.dataReading.AllowUserToAddRows = false;
            this.dataReading.AllowUserToDeleteRows = false;
            this.dataReading.AllowUserToResizeColumns = false;
            this.dataReading.AllowUserToResizeRows = false;
            this.dataReading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReading.Location = new System.Drawing.Point(278, 12);
            this.dataReading.MultiSelect = false;
            this.dataReading.Name = "dataReading";
            this.dataReading.Size = new System.Drawing.Size(240, 219);
            this.dataReading.TabIndex = 1;
            this.dataReading.Visible = false;
            this.dataReading.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReading_CellContentClick);
            // 
            // subjectScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 242);
            this.Controls.Add(this.dataReading);
            this.Controls.Add(this.dataMath);
            this.Name = "subjectScoresForm";
            this.Text = "Subject Scores";
            ((System.ComponentModel.ISupportInitialize)(this.dataMath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMath;
        private System.Windows.Forms.DataGridView dataReading;
    }
}