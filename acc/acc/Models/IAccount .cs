using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace acc.Models
{
    internal interface IAccount
    {
        public string FullNameInputChecker( string fullname);

        public string EmailInput( string email);

        public bool PasswordChecker( string password);

        public void ShowInfo();
        
    }
}
