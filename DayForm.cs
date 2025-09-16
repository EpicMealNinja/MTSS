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
    public partial class DayForm : Form
    {
        MonthCalendar _monthCalendar;
        DateTime _date;
        Student _student;
        public DayForm()
        {
            InitializeComponent();
        }
        public DayForm(MonthCalendar calSchedule, DateTime day, Student student)
        {
            InitializeComponent();

            this.Text = day.ToShortDateString();
            lblDate.Text = day.ToShortDateString();

            _monthCalendar = calSchedule;
            _date = day;
            _student = student;

            if (_student.sessions.ContainsKey(_date))
            {
                chkBxScheduleDay.Checked = true;
                tckSessionLen.Value = _student.sessions[_date];
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxScheduleDay.Checked)
            {
                try
                {
                    _monthCalendar.AddBoldedDate(_date);
                    _student.sessions.Add(_date, (int)tckSessionLen.Value);
                }
                catch (ArgumentException) { }
                
            }
            else
            {
                _monthCalendar.RemoveBoldedDate(_date);
                _student.sessions.Remove(_date);
            }
        }

        private void tckSessionLen_ValueChanged(object sender, EventArgs e)
        {
            if (!chkBxScheduleDay.Checked) return;
            _student.sessions[_date] = (int)tckSessionLen.Value;
        }
    }
}
