using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W6_01
{
    class Accounting
    {
        public virtual void CalculateTax(double amount)
        {
            double tax = amount * 0.10;
            Console.WriteLine($"Tax calculated: {tax.ToString("N0")}  Rial");
        }

        public virtual double CalculateSalary(double hoursWorked, double hourlyRate)
        {
            double salary = hoursWorked * hourlyRate;
            return salary;
            //Console.WriteLine($"Salary calculated: {salary.ToString("N0")} Rial");
        }

    }


}
   