using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class UsrCtrlAccount : UserControl
    {
        FormMain formMain; // Property
        Account account; // Property

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formMain">Instance of the main form</param>
        /// <param name="account">Account to display</param>
        public UsrCtrlAccount(FormMain formMain, Account account)
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
        private void UsrCtrlAccount_Load(object sender, EventArgs e)
        {
            lblTitle.Text = account.Title;
        }

        /// <summary>
        /// Opens the modify form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            FormModify formModify = new FormModify(formMain, account);
            formModify.ShowDialog();
        }

        /// <summary>
        /// Deletes the account and its history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Asks for a confirmation
            var confirmResult = MessageBox.Show("Are you sure to delete this account ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Deletes account and history
                SQLiteDataAccess.DeleteAccount(account);
                formMain.ReloadAccountList(SQLiteDataAccess.LoadAccounts());
            }
        }

        /// <summary>
        /// Copies the username to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyUsername_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(account.Login);
        }

        /// <summary>
        /// Copies the password to clipboard and removes it after 15 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(account.Password);
            ClearClipboard();
        }

        /// <summary>
        /// Clears the clipboard after 15 seconds
        /// </summary>
        private async void ClearClipboard()
        {
            Task.Delay(15000).Wait();
            Clipboard.Clear();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            FormModify formModify = new FormModify(formMain, account);
            formModify.ShowDialog();
        }
    }
}
