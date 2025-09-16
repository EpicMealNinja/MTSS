using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

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
        }


        // Student Data

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            student.notes = txtBxNotes.Text;
        }


        // Subjects

        private void chkBxMath_CheckedChanged(object sender, EventArgs e)
        {
            student.math = chkBxMath.Checked;
            checkBoxMath.Enabled = chkBxMath.Checked;
        }

        private void chkBxReading_CheckedChanged(object sender, EventArgs e)
        {
            student.reading = chkBxReading.Checked;
            checkBoxReading.Enabled = chkBxReading.Checked;
        }
        private void checkBoxMath_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> checkedItems = new List<string>();
            
            for (int i = 0; i < checkBoxMath.CheckedItems.Count; i++)
            {
                checkedItems.Add((string)checkBoxMath.CheckedItems[i]);
            }

            student.mathSubjects = checkedItems;
        }

        private void checkBoxReading_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in checkBoxReading.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }
            student.readingSubjects = checkedItems;
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            subjectScoresForm subjectScoresForm = new subjectScoresForm(student);
            subjectScoresForm.ShowDialog();
        }

        // Schedule


        private void calSchedule_DateSelected(object sender, DateRangeEventArgs e)
        {

            DayForm dayForm = new DayForm(calSchedule, e.Start, student);
            dayForm.ShowDialog();


            // Figure out how to refresh calendar without changing date selection
            calSchedule.Refresh();
        }

        // Save Data

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (student.firstName == "" || student.firstName == null || 
                student.lastName  == "" || student.lastName == null)
            {
                lblNoName.Visible = true;
                tmrNoName.Enabled = true;
                return;
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Student File|*.mtss";
            saveFileDialog.DefaultExt = "mtss";

            if (student.saveName == "")
                saveFileDialog.FileName = student.lastName + "_" + student.firstName;
            else 
                saveFileDialog.FileName = student.saveName;
            
            saveFileDialog.Title = "Save Student Data";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();

                // Do the saving
                // Assume for now only mtss saves
                string jsonString = JsonConvert.SerializeObject(student, Formatting.Indented);
                fs.Write(Encoding.UTF8.GetBytes(jsonString), 0, jsonString.Length);



                fs.Close();
            }

        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Student File|*.mtss",
                Title = "Open a Student File"
            };
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                //System.IO.FileStream fs = (System.IO.FileStream)openFileDialog.OpenFile();
                string jsonContent = File.ReadAllText(openFileDialog.FileName);

                // Convert json to Student
                student = JsonConvert.DeserializeObject<Student>(jsonContent);
                student.saveName = openFileDialog.SafeFileName;

                // Display Student Info
                txtBxFirstName.Text = student.firstName;
                txtBxLastName.Text = student.lastName;
                cbGrade.SelectedIndex = student.grade - 1;
                txtBxNotes.Text = student.notes;

                chkBxMath.Checked = student.math;
                checkBoxMath.Enabled = student.math;
                if (student.math)
                {
                    for (int i = 0; i < checkBoxMath.Items.Count; i++)
                    {
                        foreach (string sub in student.mathSubjects)
                        {
                            if ((string)checkBoxMath.Items[i] == sub)
                            {
                                checkBoxMath.SetItemChecked(i, true);
                            }
                        }
                    }
                }

                chkBxReading.Checked = student.reading;
                checkBoxReading.Enabled = student.reading;
                if (student.reading)
                {
                    for (int i = 0; i < checkBoxReading.Items.Count; i++)
                    {
                        foreach (string sub in student.readingSubjects)
                        {
                            if ((string)checkBoxReading.Items[i] == sub)
                            {
                                checkBoxReading.SetItemChecked(i, true);
                            }
                        }
                    }
                }

                // Update Calendar with Schedule
                foreach (var date in student.sessions)
                {
                    calSchedule.AddBoldedDate(date.Key);
                }
            }
            
        }



        // Helper

        private void tmrNoName_Tick(object sender, EventArgs e)
        {
            lblNoName.Visible = false;
            tmrNoName.Enabled = false;
        }
    }
}
