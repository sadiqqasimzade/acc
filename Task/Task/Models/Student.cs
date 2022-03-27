using System;

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
                SetPoint:
                try
                {
                    Console.Write("Points must be between 0-100\nPoints:");
                    point = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto SetPoint;
                }
            }
        }
        public bool ExamResult()
        {
            if (IQRank + LanguageRank < 120)
                return false;

            return true;
        }
    }
}
