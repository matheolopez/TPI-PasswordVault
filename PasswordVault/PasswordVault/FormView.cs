using System;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormView : Form
    {
        Account account; // Property

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="account">Account to display</param>
        public FormView(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormView_Load(object sender, EventArgs e)
        {
            // Set all texts
            txtBoxTitle.Text = account.Title;
            txtBoxLogin.Text = account.Login;
            txtBoxPassword.Text = account.Password;
            txtBoxComment.Text = account.Comment;

            EvalPassword();
        }

        /// <summary>
        /// Evaluates the password strength
        /// </summary>
        public void EvalPassword()
        {
            if (CryptClass.EvaluatePassword(txtBoxPassword.Text) == 1)
            {
                lblPasswordStrength.Text = "Weak password";
            }
            else if (CryptClass.EvaluatePassword(txtBoxPassword.Text) == 2)
            {
                lblPasswordStrength.Text = "Medium password";
            }
            else if (CryptClass.EvaluatePassword(txtBoxPassword.Text) == 3)
            {
                lblPasswordStrength.Text = "Strong password";
            }
        }

        /// <summary>
        /// Shows/hides the password
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
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
