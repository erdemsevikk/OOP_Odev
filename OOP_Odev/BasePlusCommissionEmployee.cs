using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Odev
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double _baseSalary;

        public double BaseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }

        public override double Earnings()
        {
            return (CommissionRate * GrossSales) + _baseSalary;
        }

        public override string ToString()
        {
            return "\n\nFirstName: " + FirstName + "\nLastName: " + LastName + "\nSSN: " + SSN +  "\nBaseSalary: "+ BaseSalary + "\nGrossSales: " + GrossSales + "\nCommissionRate: " + CommissionRate + "\nSalary : " + Earnings().ToString() + "\n\n********************\n";
        }
    }
}
