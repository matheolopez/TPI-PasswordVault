using System;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class UsrCtrlHistory : UserControl
    {
        Account account; // Property

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="account">Account to display</param>
        public UsrCtrlHistory(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsrCtrlHistory_Load(object sender, EventArgs e)
        {
            lblTitle.Text = account.Title;
        }

        /// <summary>
        /// Displays the form "FormView"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            FormView formView = new FormView(account);
            formView.ShowDialog();
        }
    }
}
