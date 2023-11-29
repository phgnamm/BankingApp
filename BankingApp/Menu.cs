using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                newAccount login = new newAccount ();

                if (this != null)
                {
                    login.MdiParent = this;
                    login.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCustomers list = new AllCustomers ();
            list.MdiParent = this;
            list.Show();    
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomers update = new UpdateCustomers ();
            update.MdiParent = this;
            update.Show();
        }

        private void transferFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transfer = new TransferForm ();
            transfer.MdiParent = this;  
            transfer.Show();
        }

        private void allTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alltransactions alltras = new Alltransactions ();
            alltras.MdiParent = this;
            alltras.Show();
        }

        private void searchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAccount search = new SearchAccount ();
            search.MdiParent = this;
            search.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm login = new LoginForm();
            login.ShowDialog();


        }
    }
}
