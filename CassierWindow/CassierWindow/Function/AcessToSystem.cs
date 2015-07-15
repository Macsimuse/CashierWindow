using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Silpo
{
    public class LoginPassword
    {
        const string _login = "Maks1988";
        const string _password = "1988";
        bool _acess = false;

        public bool Acess
        {
            get { return _acess; }
            set { _acess = value; }
        }

        public bool InGuard(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password)) 
                return false;
            else if (login == _login && password == _password)
            { 
                _acess = true; 
                return _acess; 
            }
            else return false;
        }
    }
}
