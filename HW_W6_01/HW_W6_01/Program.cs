using HW_W6_01;
 namespace HW_W6_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            bool repeat = true;
            while (repeat)
            {
               // Console.WriteLine("Mahboobe Ziaee");
                Console.WriteLine("1. Calculate Tax and Salary for Employee");
                Console.WriteLine("2. Calculate for a gold seller");
                Console.WriteLine("3. Exit");
                Console.WriteLine("*********************************************");
                Console.Write("Choose an option:");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                       
                        for (int employee_number = 0; employee_number < 3; employee_number++)
                       
                            employees[employee_number] = new Employee(employee_number);
                           
                        
                        for (int employee_Number = 0; employee_Number < 3; employee_Number++)
                        {
                            //double tax =employees[i].CalculateTax(employees[i].CalculateSalary(employees[i].HoursWorked[i], hourly_wage[i]));
                            double salary = employees[employee_Number].CalculateSalary(employees[employee_Number].HoursWorked, employees[employee_Number].HourlyWage);
                            Console.WriteLine("Employee Name: " + employees[employee_Number].Name);
                            employees[employee_Number].CalculateTax(employees[employee_Number].CalculateSalary(employees[employee_Number].HoursWorked, employees[employee_Number].HourlyWage));
                            Console.WriteLine($"Salary calculated for employee: {salary.ToString("N0")} Rial");
                            Console.WriteLine("------------------------------------------------------------");
                        }
                        break;
                    case 2:
                       
                        Console.WriteLine("Enter gold grams: ");
                        double goldGrams = double.Parse(Console.ReadLine());
                        GoldSeller goldSeller = new GoldSeller(goldGrams);

                        break;
                    case 3:
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, please try again");
                        break;
                }
            }
        }
    }

   
}