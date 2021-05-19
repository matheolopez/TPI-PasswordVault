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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Account account in SQLiteDataAccess.LoadAccounts())
            {
                listView1.Items.Add(account.ID.ToString());
                listView1.Items.Add(account.Title);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            //SQLiteDataAccess.ModifyAccount(new Account(2, "Test1", "Test1", "Test1", "", 0));
            SQLiteDataAccess.ModifyAccount(new Account(9, "Test3", "Test3", "Test3", "Test3", 1));
            foreach (Account account in SQLiteDataAccess.LoadAccounts())
            {
                listView1.Items.Add(account.ID.ToString());
                listView1.Items.Add(account.Title);
            }
        }
    }
}
