using System;
using System.Text.RegularExpressions;
using Task.Models;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            int choise;
            do
            {
                Console.Write("0:Quit\n1:Calculate Salary\n2:Calculate Exam Results\nChoise:");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 0: break;
                    case 1:
                        Console.Write("Age:");
                        int employerage = Convert.ToInt32(Console.ReadLine());

                        if (Person.AgeChecker(ref employerage, 18, 65))//65-pensiya)
                        {

                            Console.Write("Name:");
                            string employeename = Console.ReadLine();
                            Person.NameChecker(ref employeename);

                            Console.Write("Surname:");
                            string employeesurname = Console.ReadLine();
                            Person.SurnameChecker(ref employeesurname);

                            Console.Write("Working hours:");
                            double workinghours = Convert.ToDouble(Console.ReadLine());
                            Employee.WorkingHoursChecker(ref workinghours);

                            Console.Write("Salary for Hour:");
                            double salaryperhour = Convert.ToDouble(Console.ReadLine());
                            Employee.SalaryPerHourChecker(ref salaryperhour, ref workinghours);

                            Employee employer = new Employee(employeename, employeesurname, employerage, salaryperhour, workinghours);
                            Console.WriteLine($"Salary of {employer.Name} {employer.Surname} :{employer.CalculateSalary()}");

                        }
                        break;
                    case 2:
                        Console.Write("Age:");
                        int studentage = Convert.ToInt32(Console.ReadLine());
                        if (Person.AgeChecker(ref studentage, 6, 20))
                        {
                            Console.Write("Name:");
                            string studentname = Console.ReadLine();
                            Person.NameChecker(ref studentname);

                            Console.Write("Surname:");
                            string studentsurname = Console.ReadLine();
                            Person.SurnameChecker(ref studentsurname);

                            Console.Write("IqPoints:");
                            double iqpoints = Convert.ToDouble(Console.ReadLine());
                            Student.PointCheck(ref iqpoints);

                            Console.Write("Language Points:");
                            double languagepoints = Convert.ToDouble(Console.ReadLine());
                            Student.PointCheck(ref languagepoints);

                            Student student = new Student(studentname, studentsurname, studentage, iqpoints, languagepoints);
                            Console.WriteLine($"{student.Name} {student.Surname} Pass exam:{student.ExamResult()}");

                        }
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
            } while (choise != 0);
        }



        //static void EmployeeInputChecker(ref string employeename, ref string employeesurname, ref double salaryperhour, ref double workinghours)
        //{

        //}




    }



}
