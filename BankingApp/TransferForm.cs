using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BankingApp
{
    public partial class TransferForm : Form
    {

        int no;
        public TransferForm()
        {
            InitializeComponent();
            loaddate();
            loadAccount();
        }
        private void loadAccount()
        {
            {
                banking_dmEntities1 db = new banking_dmEntities1();
                var item = db.Transfers.ToArray();

                if (item.Length > 0)
                {
                    no = item.LastOrDefault().sno + 1;
                }
                else
                {
                    no = 1;
                }

            }
        }
        private void loaddate() {
            datelbn.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        private void btndetail_Click(object sender, EventArgs e)
        {


            banking_dmEntities1 db = new banking_dmEntities1();
            decimal fromacc;
            if (!decimal.TryParse(txtfromacc.Text, out fromacc))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản hợp lệ.");
                return;
            }

            var item = (from acc in db.userAccounts
                        where acc.Account_No == fromacc
                        select acc).FirstOrDefault();

            if (item == null)
            {
                MessageBox.Show("Số tài khoản không tồn tại trong cơ sở dữ liệu.");
                return;
            }

            txtname.Text = item.Name;
            txtamount.Text = Convert.ToString(item.balance);

        }


        private void btntransfer_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            decimal fromacc;
            if (!decimal.TryParse(txtfromacc.Text, out fromacc))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản nhận hợp lệ.");
                return;
            }

            banking_dmEntities1 db = new banking_dmEntities1();
             fromacc = Convert.ToDecimal(txtfromacc.Text);
            var fromAccount = (from acc in db.userAccounts
                               where acc.Account_No == fromacc
                               select acc).FirstOrDefault();

            if (fromAccount == null)
            {
                MessageBox.Show("Số tài khoản gửi không tồn tại trong cơ sở dữ liệu.");
                return;
            }

            decimal transferacc;
            if (!decimal.TryParse(txtdestina.Text, out transferacc))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản nhận hợp lệ.");
                return;
            }

            var transferAccount = (from acc in db.userAccounts
                                   where acc.Account_No == transferacc
                                   select acc).FirstOrDefault();

            if (transferAccount == null)
            {
                MessageBox.Show("Số tài khoản nhận không tồn tại trong cơ sở dữ liệu.");
                return;
            }

            decimal banlan = Convert.ToDecimal(fromAccount.balance);
            decimal total = Convert.ToDecimal(txttrnsfer.Text);

            if (transferacc != fromacc)
            {
                if (banlan > total)
                {
                    transferAccount.balance += total;
                    fromAccount.balance -= total;

                    Transfer transfer = new Transfer();
                    transfer.sno = no;
                    transfer.Account_No = Convert.ToDecimal(txtfromacc.Text);
                    transfer.Date = DateTime.UtcNow.ToString();
                    transfer.ToTransfer = Convert.ToDecimal(txtdestina.Text);
                    transfer.Name = txtname.Text;
                    transfer.balance = Convert.ToDecimal(txttrnsfer.Text);

                    db.Transfers.Add(transfer);
                    db.SaveChanges();

                    MessageBox.Show("Giao Dịch Thành Công");
                    btnshowall_Click(sender, e);
                    btndetail_Click(sender, e);
                    btndetail1_Click(sender, e);
                  no++;
                }
                else
                {
                    MessageBox.Show("Số tiền cần chuyển đang lớn hơn số dư trong tài khoản.");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu của bạn bị trùng lặp.");
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            decimal search;
            if (!decimal.TryParse(txtsearch.Text, out search))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản hợp lệ.");
                return;
            }

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

            if (query.Any())
            {
                dataGridView1.DataSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với số tài khoản đã nhập.");
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            banking_dmEntities1 db = new banking_dmEntities1();
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

        private bool ValidateData() {
            if (string.IsNullOrEmpty(txtfromacc.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản.");
                return false;
            }
            if (string.IsNullOrEmpty(txtdestina.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản 2.");
                return false;
            }
            if (string.IsNullOrEmpty(txttrnsfer.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền chuyển.");
                return false;
            }                                       
            return true;
        
        }

        private void btndetail1_Click(object sender, EventArgs e)
        {

            banking_dmEntities1 db = new banking_dmEntities1();
            decimal fromacc;
            if (!decimal.TryParse(txtdestina.Text, out fromacc))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản hợp lệ.");
                return;
            }

            var item = (from acc in db.userAccounts
                        where acc.Account_No == fromacc
                        select acc).FirstOrDefault();

            if (item == null)
            {
                MessageBox.Show("Số tài khoản không tồn tại trong cơ sở dữ liệu.");
                return;
            }

            txtname1.Text = item.Name;
            txtamount2.Text = Convert.ToString(item.balance);
        }
    }
}
