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
    public partial class Alltransactions : Form
    {
        public Alltransactions()
        {
            InitializeComponent();
            showListTransactions();
        }
        private void showListTransactions()
        {
            banking_dmEntities1 db = new banking_dmEntities1();

            var items = (from transfer in db.Transfers
                         join user in db.userAccounts on transfer.ToTransfer equals user.Account_No
                         orderby transfer.Date descending
                         select new
                         {
                             Date = transfer.Date,
                             Account_No = transfer.Account_No,
                             Name = transfer.Name,
                             TransferAmount = transfer.balance,
                             ToTransfer = transfer.ToTransfer,
                             ReceiverName = user.Name
                         }).ToList();

            dataGridView1.DataSource = items;

            dataGridView1.Columns["TransferAmount"].HeaderText = "Transfer Amount";


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtsearch.Text.Trim();

            banking_dmEntities1 db = new banking_dmEntities1();

            var items = (from transfer in db.Transfers
                         join user in db.userAccounts on transfer.ToTransfer equals user.Account_No
                         orderby transfer.Date descending
                         select new
                         {
                             Date = transfer.Date,
                             Account_No = transfer.Account_No,
                             Name = transfer.Name,
                             TransferAmount = transfer.balance,
                             ToTransfer = transfer.ToTransfer,
                             ReceiverName = user.Name
                         }).ToList();

           
            decimal searchDecimal;
            bool isDecimal = decimal.TryParse(searchValue, out searchDecimal);          
            items = items.Where(item =>
                item.Date.Contains(searchValue) ||
                item.Name.Contains(searchValue) ||
                item.TransferAmount.ToString().Contains(searchValue) ||
                item.ReceiverName.Contains(searchValue) ||
                item.ToTransfer == searchDecimal ||
                item.Account_No == searchDecimal
            ).ToList();

            if (items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả.");
            }
            else
            {
                dataGridView1.DataSource = items;
                dataGridView1.Columns["TransferAmount"].HeaderText = "Transfer Amount";
            }
        }
    }
}
