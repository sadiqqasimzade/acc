using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace acc.Models
{
    internal interface IAccount
    {
        public void FullNameInputChecker(ref string fullname);

        public void EmailChecker(ref string email);

        public void PasswordChecker(ref string password);

        public void ShowInfo();
        
    }
}
