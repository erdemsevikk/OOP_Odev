using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Odev
{
    public abstract class Employee
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _ssn;

        public string SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public abstract double Earnings();


    }
}
