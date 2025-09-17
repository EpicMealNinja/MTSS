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
    public partial class subjectScoresForm : Form
    {
        private Student student;
        private DataTable mathTable = new DataTable();
        private DataTable readingTable = new DataTable();

        public subjectScoresForm(Student st)
        {
            InitializeComponent();
            student = st;

            if (student.math && student.mathSubjects.Count != 0)
            {
                dataMath.Enabled = student.math;
                dataMath.Visible = student.math;

                foreach (string sub in student.mathSubjects)
                {
                    dataMath.Columns.Add(sub, sub);
                }
                dataMath.Rows.Add(8);

                for (int i = 0; i < dataMath.Rows.Count; i++)
                {
                    dataMath.Rows[i].HeaderCell.Value = "Week " + (i + 1);
                }

                // Size the table now
                
            }

            if (student.reading && student.readingSubjects.Count != 0)
            {
                dataReading.Enabled = student.reading;
                dataReading.Visible = student.reading;

                foreach (string sub in student.readingSubjects)
                {
                    dataReading.Columns.Add(sub, sub);
                }
                dataReading.Rows.Add(8);

                for(int i = 0; i < dataReading.Rows.Count; i++)
                {
                    dataReading.Rows[i].HeaderCell.Value = "Week " + (i + 1);
                }

                // Size the table now
            }
        }

        private void dataMath_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex;
            //e.ColumnIndex;
            
        }

        private void dataReading_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
