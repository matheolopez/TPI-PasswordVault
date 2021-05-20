using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormView : Form
    {
        Account account;

        public FormView(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            txtBoxTitle.Text = account.Title;
            txtBoxLogin.Text = account.Login;
            txtBoxPassword.Text = account.Password;
            txtBoxComment.Text = account.Comment;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.PasswordChar == '*')
            {
                btnShowPassword.Text = "Hide";
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            {
                btnShowPassword.Text = "Show";
                txtBoxPassword.PasswordChar = '*';
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
