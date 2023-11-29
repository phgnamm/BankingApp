using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dmEntities1 db = new banking_dmEntities1();
            if (txtuser.Text != string.Empty || txtpass.Text != string.Empty) {
            var user1 = db.Admin_Table.FirstOrDefault(a => a.Username.Equals(txtuser.Text));
            if (user1 != null) {
                    if (user1.Password.Equals(txtpass.Text))
                    {
                      this.Hide();
                      Menu menu = new Menu();
                        menu.ShowDialog();
                    }
                    else {

                        MessageBox.Show("Password is invalid");
                    }
                
                }
            
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
