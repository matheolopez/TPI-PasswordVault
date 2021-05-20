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
    public partial class UsrCtrlHistory : UserControl
    {
        Account account;

        public UsrCtrlHistory(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void UsrCtrlHistory_Load(object sender, EventArgs e)
        {
            lblTitle.Text = account.Title;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormView formView = new FormView(account);
            formView.ShowDialog();
            // ToDo:
        }
    }
}
