using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Odev
{
    class HourlyEmployee : Employee
    {
        private double _wage;

        public double Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        private double _hours;

        public double Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public override double Earnings()
        {
            if (Hours <= 40)
            {
                return _wage * _hours;
            }

            else
            {
                return 40 * _wage + (_hours - 40) * _wage * 1.5;
            }
        }

        public override string ToString()
        {
            return "\n\nFirstName: " + FirstName + "\nLastName: " + LastName + "\nSSN: " + SSN + "\nWage: " + Wage + "\nHours: "+ Hours +  "\nSalary : " +  Earnings().ToString() + "\n\n********************\n";
        }
    }
}
