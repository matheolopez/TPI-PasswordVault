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
    public partial class FormGeneratePassword : Form
    {
        public FormGeneratePassword()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxPassword.Text);
        }

        private void trckBarLength_Scroll(object sender, EventArgs e)
        {

        }

        private void txtBoxLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void chckBoxNumbers_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void chckBoxSymbols_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
