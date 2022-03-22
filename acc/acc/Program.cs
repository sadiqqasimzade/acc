using acc.Models;
using System;

namespace acc
{
    internal class Program
    {
        static void Main()
        {
            int choise;
            string fullname = "AsAs";
            string email = "fasd";
            string password = "";
            bool access=false;
            int counter = 0;
            User[] users=new User[10];
            do
            {
                Console.Write("1)FillInfo 2)ShowInfo 3)End\nChoice:");
                choise=Convert.ToInt32( Console.ReadLine());
                switch (choise)
                {
                    case 1:

                        if (counter < users.Length - 1)
                        {
                            Console.WriteLine($"Id:{User.Id}");
                            users[counter] = new User(fullname, email, password);
                            counter++;
                        }
                        else Console.WriteLine("No space available");
                        Console.WriteLine("Info filled successfully");
                        access=true;
                        break;
                        case 2:
                        if (access)
                        {
                            for (int i = 0; i < counter; i++)
                            {
                                users[i].ShowInfo();
                            }
                        }
                        else Console.WriteLine("Fill Info");
                        break;
                    case 3:break;
                    default: Console.WriteLine("Wrong Input");
                        break;
                }

               

                
            } while (choise!=3);

        }
    }
}
