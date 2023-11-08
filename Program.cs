using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Details: ");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Employee Gender (M/F): ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Date of Joining (DD/MM/YYYY): ");
            DateTime doj = DateTime.Parse(Console.ReadLine());
            double taxRate = (salary > 90000) ? 0.30 : 0.15;
            double tax = salary * taxRate;

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\t\tDOJ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t{salary:C}\t\t{doj:d}");
            Console.WriteLine("\nYou have to pay: " + tax.ToString("C"));
        }
    }
}
