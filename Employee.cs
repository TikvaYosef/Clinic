using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Employee
    {
       public string firstName;
       public string lastName;
        public string job;

        public Employee(string firstName, string lastName, string job) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.job = job;
            
        }
    }
}
