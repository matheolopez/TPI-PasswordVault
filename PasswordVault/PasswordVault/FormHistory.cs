using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormHistory : Form
    {
        List<Account> accounts;

        public FormHistory(List<Account> accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
