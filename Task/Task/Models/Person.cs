using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task.Models
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public static void NameChecker(ref string name)
        {
            Regex regex = new Regex("^[A-Z]+[a-z]+$"); 
            while (!regex.IsMatch(name))
            {
                Console.WriteLine("Name must start with upper letter and after contain olny lower letters");
                Console.Write("Name:");
                name = Console.ReadLine();
            }
        }
        public static void SurnameChecker(ref string surname)
        {
            Regex regex = new Regex("^[A-Z]+[a-z]+$");
            while (!regex.IsMatch(surname))
            {
                Console.WriteLine("Surname must start with upper letter and after contain olny lower letters");
                Console.Write("Surname:");
                surname = Console.ReadLine();
            }
        }
        public static bool AgeChecker(ref int age, int min, int max = 122)//https://en.wikipedia.org/wiki/Oldest_people
        {
            while ((age < min && age > 0) || age >= max||age<=0)
            {
                Console.WriteLine("Try Again");
                Console.Write("Age:");
                age = Convert.ToInt32(Console.ReadLine());
                if ((age < min && age > 0) || age >= max)
                {
                    //Console.WriteLine("You cant work (Legally)")
                    Console.WriteLine("You don't fit the criteria"); 
                    return false;
                }
            }
            return true;
        }
    }
}
