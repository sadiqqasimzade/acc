using System;
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
            ChoisePoint:
                try
                {
                    Console.Write("0:Quit\n1:Calculate Salary\n2:Calculate Exam Results\nChoise:");
                    choise = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto ChoisePoint;
                }
                switch (choise)
                {
                    case 0: break;
                    case 1:
                        int employerage;
                    SetEmpoyeeAgePoint:
                        try
                        {
                            Console.Write("Age between 1-122:");
                            employerage = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto SetEmpoyeeAgePoint;
                        }

                        if (Person.AgeChecker(ref employerage, 18, 65))//65-pensiya)
                        {
                            EmployeeInputChecker(out string employeename, out string employeesurname, out double salaryperhour, out double workinghours);
                            Employee employer = new Employee(employeename, employeesurname, employerage, salaryperhour, workinghours);
                            Console.WriteLine($"Salary of {employer.Name} {employer.Surname} :{employer.CalculateSalary()}");
                        }
                        break;
                    case 2:
                        int studentage;
                    SetStudentAgePoint:
                        try
                        {
                            Console.Write("Age:");
                            studentage = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto SetStudentAgePoint;
                        }


                        if (Person.AgeChecker(ref studentage, 6, 20))
                        {
                            StudentInputChecker(out string studentname, out string studentsurname, out double iqpoints, out double languagepoints);
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



        static void EmployeeInputChecker(out string employeename, out string employeesurname, out double salaryperhour, out double workinghours)
        {
            Console.Write("Name:");
            employeename = Console.ReadLine();
            Person.NameChecker(ref employeename);

            Console.Write("Surname:");
            employeesurname = Console.ReadLine();
            Person.SurnameChecker(ref employeesurname);

        //WorkingHour
        WorkingHoursInputPoint:
            try
            {
                Console.Write("Working hours:");
                workinghours = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto WorkingHoursInputPoint;
            }
            Employee.WorkingHoursChecker(ref workinghours);

        //SalaryHour
        SalaryPerHourPoint:
            try
            {
                Console.Write("Salary for Hour:");
                salaryperhour = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto SalaryPerHourPoint;
            }


            Employee.SalaryPerHourChecker(ref salaryperhour, ref workinghours);
        }

        static void StudentInputChecker(out string studentname, out string studentsurname, out double iqpoint, out double languagepoint)
        {
            Console.Write("Name:");
            studentname = Console.ReadLine();
            Person.NameChecker(ref studentname);

            Console.Write("Surname:");
            studentsurname = Console.ReadLine();
            Person.SurnameChecker(ref studentsurname);

        //IqPoint
        IqPointPoint:
            try
            {
                Console.Write("IqPoints:");
                iqpoint = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto IqPointPoint;
            }

            Student.PointCheck(ref iqpoint);

        //LanguagePoint
        LanguagePointPoint:
            try
            {
                Console.Write("Language Points:");
                languagepoint = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto LanguagePointPoint;
            }

            Student.PointCheck(ref languagepoint);
        }


    }



}
