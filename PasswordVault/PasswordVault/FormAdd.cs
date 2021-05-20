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
    public partial class FormAdd : Form
    {
        FormMain formMain;
        Account account;

        public FormAdd(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (VerifyInputs())
            {
                account = new Account(txtBoxTitle.Text, txtBoxLogin.Text, txtBoxPassword.Text, txtBoxComment.Text);
                SQLiteDataAccess.AddAccount(account);
                formMain.ReloadAccountList(SQLiteDataAccess.LoadAccounts());
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // ToDo: Evaluate password strength
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
    }
}
