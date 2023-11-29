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
    public partial class SearchAccount : Form
    {
        public SearchAccount()
        {
            InitializeComponent();
        }

        private void SearchAccount_Load(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            decimal search = Convert.ToDecimal(txtsearch.Text);
            banking_dmEntities1 db = new banking_dmEntities1();          
            var query = from cus in db.userAccounts
                        where cus.Account_No == search
                        select new
                        {
                            Account_No = cus.Account_No,
                            Name = cus.Name,
                            DOB = cus.DOB,
                            PhoneNo = cus.PhoneNo,
                            Address = cus.Address,
                            State = cus.State,
                            Picture = cus.Picture,
                            Gender = cus.Gender,
                            maritial_status = cus.maritial_status,
                            balance = cus.balance
                        };

            dataGridView1.DataSource = query.ToList();
        }
    }
}
