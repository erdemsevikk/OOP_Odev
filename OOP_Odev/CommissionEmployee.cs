using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Odev
{
    class CommissionEmployee : Employee
    {
        private double _grossSales;

        public double GrossSales
        {
            get { return _grossSales; }
            set { _grossSales = value; }
        }

        private double _commissionRate;

        public double CommissionRate
        {
            get { return _commissionRate; }
            set { _commissionRate = value; }
        }

        public override double Earnings()
        {
            return _commissionRate * _grossSales;
        }

        public override string ToString()
        {
            return "\n\nFirstName: " + FirstName + "\nLastName: " + LastName + "\nSSN: " + SSN + "\nGrossSales: " + GrossSales + "\nCommissionRate: " + CommissionRate +"\nSalary : " + Earnings().ToString() + "\n\n********************\n";
        }





    }
}
