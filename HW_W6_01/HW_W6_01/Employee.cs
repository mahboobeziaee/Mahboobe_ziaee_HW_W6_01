using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W6_01
{
    class Employee : Accounting
    {
        public string Name { get;  }
        public int HourlyWage { get;  }
        public int HoursWorked { get;  }
        public Employee(int employee_number)
        {
            int[] hourly_wage = { 300000, 235000, 69000 };
                          
                Console.Write("Enter Employee Name: ");
               Name = Console.ReadLine();
               HourlyWage = hourly_wage[employee_number];

                Console.Write("Enter Hours Worked for Employee:");
            bool validation = true;
            while (validation)
            {
                try
                {
                    HoursWorked = int.Parse(Console.ReadLine());
                    validation=false;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.Write("Enter Hours Worked for Employee:");
                    validation = true;
                }
            }
                Console.WriteLine("*********************************************************");
           

        }

        
        public override void CalculateTax(double income)
        {
            double taxRate = 0;
            
            if (income > 10000000)
            {
                Accounting accounting = new Accounting();
                accounting.CalculateTax(income);
                //taxRate = 0.10;
            }
            else if (income >= 6000000)
            {
                if (income >= 9000000)
                {
                    taxRate = 0.08;
                    double tax = income * taxRate;
                    Console.WriteLine($"Tax calculated for employee: {tax.ToString("N0")} Rial");

                }
                else if (income >= 7500000)
                {
                    taxRate = 0.07;
                    double tax = income * taxRate;
                    Console.WriteLine($"Tax calculated for employee: {tax.ToString("N0")} Rial");

                }
                else
                {
                    taxRate = 0.0;
                    double tax = income * taxRate;
                    Console.WriteLine($"Tax calculated for employee: {tax.ToString("N0")} Rial");

                }
            }

            //double tax = income * taxRate;
            //Console.WriteLine($"Tax calculated for employee: {tax.ToString("N0")} Rial");

        }

        public override double CalculateSalary(double hoursWorked, double hourlyRate)
        {
            double salary = hoursWorked * hourlyRate;
            return salary;
            //Console.WriteLine($"Salary calculated for employee: {salary.ToString("N0")} ریال");
        }

        
    }

   






}
