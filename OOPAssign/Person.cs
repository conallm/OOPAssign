using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssign
{
   public abstract class Person
    {
        //Person properties
        public string PPSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person(string pPSN, string name, string address)
        {

        }
        //overloaded Person constructor (just name)
        public Person(string name)
        {

        }

        public Person()
        {

        }
    }
}
