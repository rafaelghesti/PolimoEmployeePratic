using Polimo_Employee01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimo_Employee01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\n## Employee #{i} data ##");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }


            }
            Console.WriteLine("\n## Payments ##");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"Name: {emp.Name} - Payment: {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
