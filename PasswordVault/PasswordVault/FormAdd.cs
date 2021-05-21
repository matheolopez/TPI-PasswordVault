using System;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormAdd : Form
    {
        FormMain formMain; // Property
        Account account; // Property

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formMain">Instance of the main form</param>
        public FormAdd(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdd_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Shows and hides the password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Adds the account to the database and reloads the main form list
        /// The user is sent to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Exits this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evaluates the password strength
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // ToDo: Evaluate password strength
        }

        /// <summary>
        /// Verify that no notnull input are left empty
        /// </summary>
        /// <returns>If it is empty or not</returns>
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
