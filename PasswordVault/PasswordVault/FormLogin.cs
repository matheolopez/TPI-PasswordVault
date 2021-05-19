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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (CryptClass.Login(txtBoxPassword.Text))
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password!");
                txtBoxPassword.Focus();
            }
        }
    }
}
