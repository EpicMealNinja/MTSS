using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTSS
{
    public partial class MTSS : Form
    {
        Student student;
        public MTSS()
        {
            InitializeComponent();

            this.Text = "MTSS";

            student = new Student();

            State_Reading(false);
            State_Math(false);
        }

        private void txtBxFirstName_TextChanged(object sender, EventArgs e)
        {
            student.firstName = txtBxFirstName.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            student.lastName = txtBxLastName.Text;
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.grade = int.Parse(cbGrade.Text);
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            student.notes = rtbNotes.Text;
        }

        private void chkBxMath_CheckedChanged(object sender, EventArgs e)
        {
            student.math = chkBxMath.Checked;
        }

        private void chkBxReading_CheckedChanged(object sender, EventArgs e)
        {
            student.reading = chkBxReading.Checked;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


        }









        private void State_Reading(bool state)
        {

        }

        private void State_Math(bool state)
        {

        }
    }
}
