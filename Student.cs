using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSS
{
    internal class Student
    {
        // Name
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }

        // Grade
        public int grade
        {
            get; set;
        }

        // Subjects
        public bool math
        {
            get; set;
        }
        public bool reading
        {
            get; set;
        }

        // Notes
        public string notes
        {
            get; set;
        }

    }
}
