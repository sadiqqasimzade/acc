using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    internal class Student : Person
    {
        public double IQRank { get; set; }
        public double LanguageRank { get; set; }

        public Student(string name, string surname, int age, double iqrank, double languagerank)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IQRank = iqrank;
            LanguageRank = languagerank;
        }

        

        public static void PointCheck(ref double point)
        {
            while (point > 100 || point < 0)
            {
                Console.Write("Points:");      
                point = Convert.ToDouble(Console.ReadLine());
            } 
        }
        public bool ExamResult()
        {
            if (IQRank + LanguageRank < 120) return false;
            return true;
        }
    }
}
