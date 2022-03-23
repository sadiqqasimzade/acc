using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace acc.Models
{
    internal class User : IAccount
    {
        private int _id;//obyektin  id-si
        private string _fullname;
        private string _email;
        private string _password;
        public static int Id { get; private set; }//classin id-si
        public string FullName { get { return _fullname; } set {_fullname= FullNameInputChecker(value); } }
        public string Email { get { return _email; } set {_email= EmailChecker(value); } }
        public string Password
        {
            get //parol gizli qalsin deye
            {
                char[] encrypted = _password.ToCharArray();
                Array.Reverse(encrypted);
                return String.Concat(encrypted);
            }
            set
            {
               _password= PasswordChecker(value);
                

            }
        }

        public User(string fullname, string email, string password)
        {
            FullName = fullname;
            Email = email;
            Password = password;
            Id++;
            _id = Id;
        }
        public string FullNameInputChecker(string fullname)
        {
            Regex regex = new Regex("^[A-z][a-z]+[' '][A-Z][a-z]+$");
            while (!regex.IsMatch(fullname))
            {
                Console.Write("FullName:");
                fullname = Console.ReadLine();
            }
            return fullname;
        }
        public string EmailChecker(string email)
        {
            Regex regex = new Regex("^([a-zA-Z]+[a-zA-z.!#$%&'*+-=?^`{|}~]{0,64})+[@]+[a-zA-z-]+[.]+[a-zA-z]+$"); //https://en.wikipedia.org/wiki/Email_address 
            while (!regex.IsMatch(email))                                                                                                   //qaydalara uygundu ancacq ip aressler nezer alinmayib
            {
                Console.Write("Email:");
                email = Console.ReadLine();
            }
            return email;
        }
        public string PasswordChecker(string password)
        {
            Regex regex = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])+[a-zA-z0-9]{8,}$");
            while (!regex.IsMatch(password))
            {
                Console.Write("Password:");
                password = Console.ReadLine();
            }
            return password;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{_id}\nFull name {FullName}\nEmail {Email}\nPass {Password}");
        }


    }
}
