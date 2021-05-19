using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class Account
    {
        public Account(string title, string login, string password, string comment = "")
        {
            Title = title;
            Login = login;
            Password = password;
            Comment = comment;
            Last = 1;
        }

        public Account(int id, string title, string login, string password, string comment, int last)
        {
            ID = id;
            Title = title;
            Login = login;
            Password = password;
            Comment = comment;
            Last = last;
        }

        public Account()
        {
            Last = 1;
        }

        public int ID  // property
        { get; set; }

        public string Title  // property
        { get; set; }

        public string Login  // property
        { get; set; }

        public string Password  // property
        { get; set; }

        public string Comment  // property
        { get; set; }

        public int Last  // property
        { get; set; }
    }
}
