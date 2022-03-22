using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace acc.Models
{
    internal class User : IAccount
    {
        private int _id;
        public static int Id { get; private set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public User(string fullname, string email, string password)
        {
            FullNameInputChecker(ref fullname);
            FullName = fullname;
            EmailChecker(ref email);
            Email = email;
            PasswordChecker(ref password);
            Password = password;
            Id++;
            _id = Id;
        }
        public  void FullNameInputChecker(ref string fullname)
        {
            Regex regex = new Regex("^[A-z][a-z]+[' '][A-Z][a-z]+$");
            while (!regex.IsMatch(fullname))
            {
                Console.Write("FullName:");
                fullname = Console.ReadLine();
            } 
        }
        public void EmailChecker(ref string email)
        {
            Regex regex = new Regex("^([a-zA-Z]+[a-zA-z.!#$%&'*+-=?^`{|}~]{0,64})+[@]+[a-zA-z-]+[.]+[a-zA-z]+$"); //https://en.wikipedia.org/wiki/Email_address 
            while (!regex.IsMatch(email))                                                                                                   //qaydalara uygundu ancacq ip aressler nezer alinmayib
            {
                Console.Write("Email:");
                email = Console.ReadLine();
            } 
        }
        public void PasswordChecker(ref string password)
        {
            Regex regex = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])+[a-zA-z0-9]{8,}$");
            while (!regex.IsMatch(password))
            {
                Console.Write("Password:");
                password = Console.ReadLine();
            } 
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{_id}\nFull name {FullName}\nEmail {Email}");
        }

       
    }
}
