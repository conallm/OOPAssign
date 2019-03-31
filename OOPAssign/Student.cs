using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssign
{
   public class Student:Person
    {
        //Student specific proprties
        public string StudentId { get; set; }
        public string Status { get; set; }

        //student constructor with student properties and inheriting from Person class 

        public Student(string name, string studentId, string status, string pPSN, string address )
        :base(pPSN, name, address)
        {
            StudentId = studentId;
            Status = status;
        }

        public Student(string name)
            :base(name)
        {

        }

        public Student()
        {

        }
    }
}
