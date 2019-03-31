using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssign
{
    public class Staff:Person
    {
        //set properties
        public string Id { get; set; }
        public int Salary { get; set; }

        //create 
        public Staff(string pPSN, string name, string address, string id, int salary)
            :base(pPSN, name, address)
        {
            Id = id;
            Salary = salary;
        }

        public Staff(string name)
            :base(name)
        {

        }
    }
}
