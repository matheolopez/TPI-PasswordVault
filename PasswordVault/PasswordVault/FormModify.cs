using System;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormModify : Form
    {
        FormMain formMain; // Property
        Account account; // Property

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formMain">Instance of the main form</param>
        /// <param name="account">Account to display/modify</param>
        public FormModify(FormMain formMain, Account account)
        {
            InitializeComponent();

            this.formMain = formMain;
            this.account = account;
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModify_Load(object sender, EventArgs e)
        {
            // Display all texts
            txtBoxTitle.Text = account.Title;
            txtBoxLogin.Text = account.Login;
            txtBoxPassword.Text = account.Password;
            txtBoxComment.Text = account.Comment;
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
        /// Gets the history of the account and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory(SQLiteDataAccess.GetHistory(account));
            formHistory.ShowDialog();
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
        /// Get all the entered infos and sends it to the database
        /// The user is sent to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (VerifyInputs())
            {
                account.Title = txtBoxTitle.Text;
                account.Login = txtBoxLogin.Text;
                account.Password = txtBoxPassword.Text;
                account.Comment = txtBoxComment.Text;

                // Modifies account and reload the main page list
                SQLiteDataAccess.ModifyAccount(account);
                formMain.ReloadAccountList(SQLiteDataAccess.LoadAccounts());
                // Exits this form
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
    }
}
