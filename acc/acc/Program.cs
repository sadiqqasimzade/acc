using acc.Models;
using System;

namespace acc
{
    internal class Program
    {
        static void Main()
        {

            int choise;
            string fullname ;
            string email ;
            string password;
            User[] users = new User[0];
            do
            {
            Point1:
                try
                {
                    Console.Write("1)Create User 2)ShowInfo 3)End\nChoice:");
                    choise = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Point1;
                }

                switch (choise)
                {
                    case 1:

                        Console.Write($"user-{User.Id} fullname:");
                        fullname = Console.ReadLine();
                        Console.Write($"user-{User.Id} email:");
                        email = Console.ReadLine();
                        Console.Write($"user-{User.Id} password:");
                        password = Console.ReadLine();

                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = new User(fullname, email, password);
                        Console.WriteLine("Info filled successfully");
                        break;
                    case 2:
                        foreach (var user in users)
                            user.ShowInfo();
                        break;
                    case 3: break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 3);

        }
       

    }
}
