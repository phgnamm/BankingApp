using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BankingApp
{
    public partial class AllCustomers : Form
    {
        public AllCustomers()
        {
            InitializeComponent();
            showListCustomers();
        }

        private void showListCustomers() { 
        banking_dmEntities1 db =new banking_dmEntities1();
           var item = db.userAccounts.ToList();                 
           // dataGridView1.RowTemplate.Height = 150;
          //  dataGridView1.Columns["Picture"].Width = 150;
            dataGridView1.DataSource = item.Select(cus => new {
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
            }).ToList();
        
        }
    }
}
