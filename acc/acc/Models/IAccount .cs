using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace acc.Models
{
    internal interface IAccount
    {
        public string FullNameInputChecker( string fullname);

        public string EmailChecker( string email);

        public string PasswordChecker( string password);

        public void ShowInfo();
        
    }
}
