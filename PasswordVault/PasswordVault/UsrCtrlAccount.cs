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
    public partial class UsrCtrlAccount : UserControl
    {
        FormMain formMain;
        Account account;

        public UsrCtrlAccount(FormMain formMain, Account account)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.account = account;
        }

        private void UsrCtrlAccount_Load(object sender, EventArgs e)
        {
            lblTitle.Text = account.Title;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormModify formModify = new FormModify(formMain, account);
            formModify.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SQLiteDataAccess.DeleteAccount(account);
            formMain.ReloadAccountList(SQLiteDataAccess.LoadAccounts());
        }

        private void btnCopyUsername_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(account.Login);
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(account.Password);
            ClearClipboard();
        }

        private async void ClearClipboard()
        {
            Task.Delay(15000).Wait();
            Clipboard.Clear();
        }
    }
}
