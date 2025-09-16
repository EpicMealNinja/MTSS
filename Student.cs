using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSS
{
    public class Student
    {
        // Default Constructor
        public Student()
        {
            firstName = "";
            lastName = "";

            math = false;
            reading = false;

            mathSubjects = new List<string>();
            readingSubjects = new List<string>();

            sessions = new Dictionary<DateTime, int>();

            notes = "";

            saveName = "";
        }

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
        public List<string> mathSubjects
        {
            get; set;
        }

        public bool reading
        {
            get; set;
        }
        public List<string> readingSubjects
        {
            get; set;
        }

        public Dictionary<string, List<int>> subjectScores
        {
            get; set;
        }

        // Sessions
        public Dictionary<DateTime, int> sessions;

        // Notes
        public string notes
        {
            get; set;
        }


        // Helper Data

        public string saveName
        {
            get; set;
        }

        

    }
}
