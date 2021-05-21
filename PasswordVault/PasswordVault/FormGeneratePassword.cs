using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormGeneratePassword : Form
    {
        public FormGeneratePassword()
        {
            InitializeComponent();
        }

        private void FormGeneratePassword_Load(object sender, EventArgs e)
        {
            txtBoxLength.Text = trckBarLength.Value.ToString();
            txtBoxPassword.Text = GeneratePassword();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxPassword.Text);
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

        private string GeneratePassword()
        {
            bool numbers = chckBoxNumbers.Checked;
            bool symbols = chckBoxSymbols.Checked;
            int length = trckBarLength.Value;

            List<char> passChars = new List<char>();
            Random random = new Random();
            if (numbers && symbols)
            {
                for (int i = 0; i < ((length - 6) / 2); i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(65, 90)));
                    passChars.Add(Convert.ToChar(random.Next(97, 122)));
                }
                for (int i = 0; i < 3; i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(33, 47)));
                    passChars.Add(Convert.ToChar(random.Next(48, 57)));
                }
            }
            else if (numbers && !symbols)
            {
                for (int i = 0; i < ((length - 6) / 2); i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(65, 90)));
                    passChars.Add(Convert.ToChar(random.Next(97, 122)));
                }
                for (int i = 0; i < 6; i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(48, 57)));
                }
            }
            else if (!numbers && symbols)
            {
                for (int i = 0; i < ((length - 6) / 2); i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(65, 90)));
                    passChars.Add(Convert.ToChar(random.Next(97, 122)));
                }
                for (int i = 0; i < 6; i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(33, 47)));
                }
            }
            else if (!numbers && !symbols)
            {
                for (int i = 0; i < ((length) / 2); i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(65, 90)));
                    passChars.Add(Convert.ToChar(random.Next(97, 122)));
                }
            }

            Shuffle(passChars);
            return new string(passChars.ToArray());
        }

        private void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void trckBarLength_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxLength.Text = trckBarLength.Value.ToString();
            txtBoxPassword.Text = GeneratePassword();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }
    }
}
