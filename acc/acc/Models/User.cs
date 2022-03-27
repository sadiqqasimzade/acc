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
        public string FullName { get { return _fullname; } set { _fullname = FullNameInputChecker(value); } }
        public string Email { get { return _email; } set { _email = EmailInput(value); } }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {   
                _password = PasswordInput(value);
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

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{_id}\nFull name: {FullName}\nEmail: {Email}");
        }
        
        //FullNameInput
        public string FullNameInputChecker(string fullname)
        {
            Regex regex = new Regex("^[A-z][a-z]+[' '][A-Z][a-z]+$");

            while (!regex.IsMatch(fullname))
            {
                Console.WriteLine("Wrong Full Name Input");
                Console.Write("FullName:");
                fullname = Console.ReadLine();
            }

            return fullname;
        }

        //Email input
        public string EmailInput(string email)
        {
            Regex regex = new Regex("^([a-zA-Z]+[a-zA-z.!#$%&'*+-=?^`{|}~]{0,64})+[@]+[a-zA-z-]+[.]+[a-zA-z]+$"); //https://en.wikipedia.org/wiki/Email_address 
            while (!regex.IsMatch(email))
            {
                Console.WriteLine("Wrong Email Input");
                Console.Write("Email:");
                email = Console.ReadLine();
            }
            return email;
        }


        //PasswordChecker             taskin sertinde olduguna gore yazim ancaq kodun bu hissesi olmasa daha menali olar
        public bool PasswordChecker(string password)
        {
            Regex regex = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])+[a-zA-z0-9]{8,}$");
            if (regex.IsMatch(password)) return true;
            return false;
        }


        //PasswordInput
        public string PasswordInput(string password)
        {
            while (!PasswordChecker(password))
            {
                Console.WriteLine("Wrong Password Input");
                Console.Write("Password:");
                password = Console.ReadLine();
            }
            return password;
        }

    }
}
