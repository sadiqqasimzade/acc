using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    internal class Employee:Person
    {
        double SalaryHour { get; set; }
        double WorkingHour { get; set; }

        public Employee(string name, string surname, int age, double salaryhour, double workinghour)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SalaryHour = salaryhour;
            WorkingHour = workinghour;
        }
        public static void WorkingHoursChecker(ref double workinghours)
        {
            while (workinghours / 26 > 8 || workinghours == 0) //heftenin 6 gununu is gunu kimi goturdum
            {
                Console.WriteLine("VIOLATION OF THE GOVERMENT LAW");
                Console.Write("Working Hours:");
                workinghours = Convert.ToDouble(Console.ReadLine());
            }
        }

        public static void SalaryPerHourChecker(ref double salaryperhour, ref double workinghours)
        {
            while (workinghours * salaryperhour < 250)
            {
                Console.WriteLine("VIOLATION OF THE GOVERMENT LAW");
                Console.Write("Salary per Hour:");
                salaryperhour = Convert.ToDouble(Console.ReadLine());
            }
        }

        public double CalculateSalary()
        {
            return SalaryHour * WorkingHour;
        }
    }
}
