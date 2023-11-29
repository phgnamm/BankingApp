using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class UpdateCustomers : Form
    {
        private MemoryStream ms; // Biến để lưu trữ dữ liệu hình ảnh
        private string gender;
        private string m_status;
        private banking_dmEntities1 db;

        public UpdateCustomers()
        {
            InitializeComponent();
            loadState();
            loaddate();
        }

        private void loaddate()
        {
            datebl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void loadState()
        {
            cbtxtstate.Items.Add("VietNam");
            cbtxtstate.Items.Add("Lao");
            cbtxtstate.Items.Add("CamPuChia");
            cbtxtstate.Items.Add("ThaiLan");
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            db = new banking_dmEntities1();
            var items = db.userAccounts.ToList();

            dataGridView1.DataSource = items.Select(cus => new
            {
                Account_No = cus.Account_No,
                Name = cus.Name,
                DOB = cus.DOB,
                PhoneNo = cus.PhoneNo,
                Address = cus.Address,
                State = cus.State,
                Picture = cus.Picture,
                Gender = cus.Gender,
                Marital_Status = cus.maritial_status,
                Balance = cus.balance
            }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                accounttxt.Text = row.Cells["Account_No"].Value.ToString();
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtphone.Text = row.Cells["PhoneNo"].Value.ToString();
                txtaddress.Text = row.Cells["Address"].Value.ToString();
                cbtxtstate.Text = row.Cells["State"].Value.ToString();
                txtbalance.Text = row.Cells["Balance"].Value.ToString();

                // Kiểm tra giá trị của cột "Picture" có hợp lệ (khác null) trước khi hiển thị hình ảnh
                if (row.Cells["Picture"].Value != null)
                {
                    // Lấy giá trị của cột "Picture" và chuyển đổi thành một đối tượng Image
                    byte[] imageData = (byte[])row.Cells["Picture"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        this.ms = ms; // Lưu trữ MemoryStream để sử dụng khi nhấn nút "Save"
                    }
                }
                else
                {
                    pictureBox1.Image = null; // Xóa hình ảnh trong PictureBox nếu giá trị cột "Picture" là null
                    this.ms = null; // Đặt giá trị MemoryStream là null
                }
                string gender = row.Cells["Gender"].Value.ToString();
                string maritalStatus = row.Cells["Marital_Status"].Value.ToString();
                if (gender == "male")
                {
                    maleradio.Checked = true;
                }
                else if (gender == "female")
                {
                    femaleradio.Checked = true;
                }
                else if (gender == "other")
                {
                    otherradio.Checked = true;
                }

                if (maritalStatus == "unmarried")
                {
                    unmarriedradio.Checked = true;
                }
                else if (maritalStatus == "married")
                {
                    marriedradio.Checked = true;
                }
            }
        
        
        }

        private void btnloadphto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            db = new banking_dmEntities1();
            // Kiểm tra xem có hàng được chọn trong DataGridView hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Trích xuất số tài khoản từ hàng được chọn
                decimal accountNo = Convert.ToDecimal(selectedRow.Cells["Account_No"].Value);

                // Truy vấn thông tin tài khoản từ cơ sở dữ liệu dựa trên số tài khoản
                var userAccount = db.userAccounts.FirstOrDefault(cus => cus.Account_No == accountNo);

                if (userAccount != null)
                {
                    
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user account?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        db.userAccounts.Remove(userAccount);
                        db.SaveChanges();
                        updateData(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user account to delete.");
            }
        }

        private void updateData()
        {
            db = new banking_dmEntities1();
            var items = db.userAccounts.ToList();

            dataGridView1.DataSource = items.Select(cus => new
            {
                Account_No = cus.Account_No,
                Name = cus.Name,
                DOB = cus.DOB,
                PhoneNo = cus.PhoneNo,
                Address = cus.Address,
                State = cus.State,
                Picture = cus.Picture,
                Gender = cus.Gender,
                Marital_Status = cus.maritial_status,
                Balance = cus.balance
            }).ToList();
        }

        private void btnsavebt_Click(object sender, EventArgs e)
        {
            db = new banking_dmEntities1();
            decimal accountId = Convert.ToDecimal(accounttxt.Text);
            var userAccount = db.userAccounts.FirstOrDefault(user => user.Account_No == accountId);
            if (!ValidateData())
            {
                return;
            }
            else
            {
                if (userAccount != null)
                {
                    if (maleradio.Checked)
                    {
                        gender = "male";
                    }
                    else if (femaleradio.Checked)
                    {
                        gender = "female";
                    }
                   
                    else if (otherradio.Checked)
                    {
                        gender = "other";
                    }

                    if (unmarriedradio.Checked)
                    {
                        m_status = "unmarried";
                    }
                    else if (marriedradio.Checked)
                    {
                        m_status = "married";
                    }

                    userAccount.Name = txtname.Text;
                    userAccount.DOB = dateTimePicker1.Value.ToString();
                    userAccount.PhoneNo = txtphone.Text;
                    userAccount.Address = txtaddress.Text;
                    userAccount.State = cbtxtstate.SelectedItem?.ToString();
                    userAccount.balance = Convert.ToDecimal(txtbalance.Text);
                    userAccount.Picture = ms?.ToArray(); // Sử dụng MemoryStream chỉ khi nó khác null
                    userAccount.Gender = gender;
                    userAccount.maritial_status = m_status;

                    db.SaveChanges();
                    updateData();
                    MessageBox.Show("Updated successfully.");
                }
                else
                {
                    MessageBox.Show("User account not found.");
                }
            }
        }
        private bool ValidateData()
        {           

            if (!long.TryParse(txtphone.Text, out long phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                txtphone.Text = string.Empty;
                return false;
            }
       

            if (!decimal.TryParse(txtbalance.Text, out decimal balance))
            {
                MessageBox.Show("Số dư tài khoản không hợp lệ. Vui lòng nhập lại.");
                txtbalance.Text = string.Empty;
                return false;
            }
            return true;
        }
    }
    }
