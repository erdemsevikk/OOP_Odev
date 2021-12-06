using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Odev
{
    class SalariedEmployee : Employee
    {
        private double _weeklySalary;

        public double WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        public override double Earnings()
        {
            return _weeklySalary;
        }

        public override string ToString()
        {
            return "\n\nFirstName: " + FirstName + "\nLastName: " + LastName + "\nSSN: " + SSN + "\nSalary : " + Earnings().ToString() + "\n\n********************\n";
            
        }



    }
}
