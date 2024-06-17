using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W6_01
{
    class GoldSeller : Accounting
    {
        public GoldSeller(double goldGrams)
        {
            CalculateTax(goldGrams);
           double netSalary= CalculateSalary(24, 1500000); // Assuming daily wage of 1.5 million and 6 rest days per month
            Console.WriteLine($"Salary calculated for gold seller: {netSalary.ToString("N0")} Rial");
            Console.WriteLine("....................................................");
        }

        public override void CalculateTax(double goldGrams)
        {
            double goldPricePerGram = 3000000;
            double goldValue = goldGrams * goldPricePerGram;
            double vatTax = goldValue * 0.10;
            double tradeTax = goldValue * 0.15;
            double totalTax = vatTax + tradeTax;
            Console.WriteLine($"Tax calculated for gold seller: {totalTax.ToString("N0")} Rial");
        }

        public override double CalculateSalary(double daysWorked, double dailyWage)
        {
            double monthlyWage = daysWorked * dailyWage;
            double deduction = 6 * dailyWage;
            double netSalary = monthlyWage - deduction;
            return netSalary;
           // Console.WriteLine($"Salary calculated for gold seller: {netSalary.ToString("N0")} ریال");
        }
    }


}
