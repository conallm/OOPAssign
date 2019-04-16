using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssign
{
    public class Lecturer:Staff
    {
        //Lecturer attributes
        public string SubjectArea { get; set; }
        public List<Subject> SubjectsTaught = new List<Subject>();
        public int YearsExper { get; set; }

        //Lecturer constructor
        public Lecturer(string name, string pPSN, string address, string id, int salary, string subjectArea, List<Subject> subjectsTaught, int yearsExper)
            :base(name, pPSN, address, id, salary)
        {
            SubjectArea = subjectArea;
            SubjectsTaught = subjectsTaught;
            YearsExper = yearsExper;
        }
        //overloaded Lecturer constructor
        public Lecturer(string name)
            :base(name)
        {

        }
        public Lecturer()
        {

        }
    }
}
 