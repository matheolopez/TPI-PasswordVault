using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormMain : Form
    {
        List<Account> accounts; // Property

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            accounts = new List<Account>();
            accounts = SQLiteDataAccess.LoadAccounts();
            ReloadAccountList(accounts);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // ToDo:
        }

        /// <summary>
        /// Opens the form "FormAdd"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }

        /// <summary>
        /// Opens the form "FormGeneratePassword"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            FormGeneratePassword formGeneratePassword = new FormGeneratePassword();
            formGeneratePassword.ShowDialog();
        }

        /// <summary>
        /// Reload the panel with all accounts to display
        /// </summary>
        /// <param name="accounts">Accounts to display</param>
        public void ReloadAccountList(List<Account> accounts)
        {
            pnlAccounts.Controls.Clear();
            int numAccounts = 0;
            foreach (Account account in accounts)
            {
                UsrCtrlAccount usrCtrlAccount = new UsrCtrlAccount(this, account);
                pnlAccounts.Controls.Add(usrCtrlAccount);
                usrCtrlAccount.Location = new Point(0, usrCtrlAccount.Size.Height * numAccounts);
                numAccounts++;
            }
        }
    }
}
