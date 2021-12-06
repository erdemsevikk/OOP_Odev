using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee S1 = new SalariedEmployee();
            S1.FirstName = "Erdem";
            S1.LastName = "Şevik";
            S1.SSN = "000001";
            S1.WeeklySalary = 1000;

            Console.WriteLine("SalariedEmployee : " + S1.ToString());

            CommissionEmployee C1 = new CommissionEmployee();
            C1.FirstName = "Nur";
            C1.LastName = "Uysal";
            C1.SSN = "000002";
            C1.GrossSales = 5000;
            C1.CommissionRate = 0.20;

            Console.WriteLine("CommissionEmployee : " + C1.ToString());

            HourlyEmployee H1 = new HourlyEmployee();
            H1.FirstName = "İso";
            H1.LastName = "Şevik";
            H1.SSN = "000003";
            H1.Wage = 25;
            H1.Hours = 40;

            Console.WriteLine("HourlyEmployee : " + H1.ToString());

            BasePlusCommissionEmployee B1 = new BasePlusCommissionEmployee();
            B1.FirstName = "Zafer";
            B1.LastName = "Culfa";
            B1.SSN = "000004";
            B1.BaseSalary = 500;
            B1.GrossSales = 5000;
            B1.CommissionRate = 0.1;

            Console.WriteLine("BasePlusCommissionEmployee : " + B1.ToString());

            Console.ReadLine();
        }
    }
}
