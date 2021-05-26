using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class FormGeneratePassword : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FormGeneratePassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load method of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGeneratePassword_Load(object sender, EventArgs e)
        {
            txtBoxLength.Text = trckBarLength.Value.ToString();
            txtBoxPassword.Text = GeneratePasswordV2();
        }

        /// <summary>
        /// Copies the password to the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxPassword.Text);
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

        /// <summary>
        /// Generates a password with the desired length, numbers and symbols
        /// </summary>
        /// <returns>The password as a string</returns>
        private string GeneratePasswordV2()
        {
            // Set variables
            bool numbers = chckBoxNumbers.Checked;
            bool symbols = chckBoxSymbols.Checked;
            int length = trckBarLength.Value;

            List<char> passChars = new List<char>();
            Random random = new Random();

            // NUMS + SYMBOLS
            if (numbers && symbols)
            {
                for (int i = 0; i < length / 4; i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(48, 57)));
                    passChars.Add(Convert.ToChar(random.Next(33, 47)));
                }
            }
            // NUMS
            else if (numbers && !symbols)
            {
                for (int i = 0; i < length / 2; i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(48, 57)));
                }
            }
            // SYMBOLS
            else if (!numbers && symbols)
            {
                for (int i = 0; i < length / 2; i++)
                {
                    passChars.Add(Convert.ToChar(random.Next(33, 47)));
                }
            }
            // Add LETTERS
            while (length - passChars.Count >= 2)
            {
                passChars.Add(Convert.ToChar(random.Next(65, 90)));
                passChars.Add(Convert.ToChar(random.Next(97, 122)));
            }
            if (length - passChars.Count == 1)
            {
                passChars.Add(Convert.ToChar(random.Next(65, 90)));
            }

            // Shuffle the chars and return as a string
            passChars = Shuffle(passChars);
            return new string(passChars.ToArray());
        }

        /// <summary>
        /// Shufflues a list of chars
        /// </summary>
        /// <param name="list">List to shuffle</param>
        /// <returns>Shuffled list of chars</returns>
        private List<char> Shuffle(List<char> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        /// <summary>
        /// Displays the length and generates a password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trckBarLength_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxLength.Text = trckBarLength.Value.ToString();
            txtBoxPassword.Text = GeneratePasswordV2();
        }

        /// <summary>
        /// Generates a password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Text = GeneratePasswordV2();
        }

        /// <summary>
        /// Generates a password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chckBoxNumbers_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.Text = GeneratePasswordV2();
        }

        /// <summary>
        /// Generates a password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chckBoxSymbols_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.Text = GeneratePasswordV2();
        }
    }
}
