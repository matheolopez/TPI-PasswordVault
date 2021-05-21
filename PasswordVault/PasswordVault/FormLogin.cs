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
    public partial class FormLogin : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Tries to connect the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            // If password is right, open main form and close this one
            if (CryptClass.Login(txtBoxPassword.Text))
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                this.Close();
            }
            // If password is wrong, display message
            else
            {
                MessageBox.Show("Wrong password!");
                txtBoxPassword.Focus();
            }
        }
    }
}
