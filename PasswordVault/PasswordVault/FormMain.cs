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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<Account> accounts;

        private void FormMain_Load(object sender, EventArgs e)
        {
            accounts = new List<Account>();
            accounts = SQLiteDataAccess.LoadAccounts();
            ReloadAccountList(accounts);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {

        }

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
