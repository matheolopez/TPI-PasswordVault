using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormHistory : Form
    {
        List<Account> accounts; // Property

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="accounts">Accounts to display</param>
        public FormHistory(List<Account> accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHistory_Load(object sender, EventArgs e)
        {
            // Display all the history
            pnlHistory.Controls.Clear();
            int numAccounts = 0;
            foreach (Account account in accounts)
            {
                UsrCtrlHistory usrCtrlHistory = new UsrCtrlHistory(account);
                pnlHistory.Controls.Add(usrCtrlHistory);
                usrCtrlHistory.Location = new Point(0, usrCtrlHistory.Size.Height * numAccounts);
                numAccounts++;
            }
        }

        /// <summary>
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
