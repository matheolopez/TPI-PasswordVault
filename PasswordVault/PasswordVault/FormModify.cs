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
    public partial class FormModify : Form
    {
        FormMain formMain;
        Account account;

        public FormModify(FormMain formMain, Account account)
        {
            InitializeComponent();

            this.formMain = formMain;
            this.account = account;

            txtBoxTitle.Text = account.Title;
            txtBoxLogin.Text = account.Login;
            txtBoxPassword.Text = account.Password;
            txtBoxComment.Text = account.Comment;
        }

        private void FormModify_Load(object sender, EventArgs e)
        {
            
        }

        private bool VerifyInputs()
        {
            if (txtBoxTitle.Text != null && txtBoxTitle.Text != "")
            {
                if (txtBoxLogin.Text != null && txtBoxLogin.Text != "")
                {
                    if (txtBoxPassword.Text != null && txtBoxPassword.Text != "")
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the password!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in the login!");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the title!");
            }
            return false;
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // ToDo: Evaluate password strength
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // ToDo: Open history
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (VerifyInputs())
            {
                account.Title = txtBoxTitle.Text;
                account.Login = txtBoxLogin.Text;
                account.Password = txtBoxPassword.Text;
                account.Comment = txtBoxComment.Text;
            }
            SQLiteDataAccess.ModifyAccount(account);
            formMain.ReloadAccountList(SQLiteDataAccess.LoadAccounts());
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
