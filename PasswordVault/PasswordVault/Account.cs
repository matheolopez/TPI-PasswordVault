using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class Account
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Title of the account</param>
        /// <param name="login">Login of the account</param>
        /// <param name="password">Password of the account</param>
        /// <param name="comment">Comment of the account</param>
        public Account(string title, string login, string password, string comment = "")
        {
            Title = title;
            Login = login;
            Password = password;
            Comment = comment;
            Last = 1;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">ID of the account</param>
        /// <param name="title">Title of the account</param>
        /// <param name="login">Login of the account</param>
        /// <param name="password">Password of the account</param>
        /// <param name="comment">Comment of the account</param>
        /// <param name="last">Active indicator of the account</param>
        public Account(int id, string title, string login, string password, string comment, int last)
        {
            ID = id;
            Title = title;
            Login = login;
            Password = password;
            Comment = comment;
            Last = last;
        }

        /// <summary>
        /// Constructor
        /// </summary>
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
