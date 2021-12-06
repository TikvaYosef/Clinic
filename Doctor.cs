using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{

    public class Doctor: Employee ,IComparable
    {
        public int numOfPatients;
        public int yearOfBirth;

        public Doctor(int numOfPatients, int yearOfBirth,string firstName, string lastName,string job):base (firstName, lastName,job)
        {
            this.numOfPatients = numOfPatients;
            this.yearOfBirth = yearOfBirth;
           
        }
        public int CompareTo(object? obj)
        {
            Doctor somenum = (Doctor)obj;
            if (this.numOfPatients < somenum.numOfPatients)
            {
                return -1;
            }
            if (this.numOfPatients > somenum.numOfPatients)
            {
                return 1;
            }
            return 0;
        }

        

    }
}
