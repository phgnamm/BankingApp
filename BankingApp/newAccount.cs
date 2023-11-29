using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        banking_dmEntities1 db;
        MemoryStream ms;
        decimal no;

        public newAccount()
        {
            InitializeComponent();
            loadAccount();
            loaddate();
            loadState();
        }

        private void loadState() {
            cbtxtstate.Items.Add("VietNam");
            cbtxtstate.Items.Add("Lao");
            cbtxtstate.Items.Add("CamPuChia");
            cbtxtstate.Items.Add("ThaiLan");

        }

        private void loadAccount() {
            {
                db = new banking_dmEntities1();
                var item = db.userAccounts.ToArray();

                if (item.Length > 0)
                {
                    no = item.LastOrDefault().Account_No + 1;
                }
                else
                {
                    no = 1;
                }

                accounttxt.Text = Convert.ToString(no);
            }
        }

        private void loaddate() {
            datebl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        
        }

        private void btnloadphto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) { 
            Image  img = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void btnsavebt_Click(object sender, EventArgs e)
        {
             if (!ValidateData())
    {
        return;
    }
    else
    {
        // Kiểm tra trùng lặp của accounttxt
        decimal accountNo = Convert.ToDecimal(accounttxt.Text);
        db = new banking_dmEntities1();
        bool isAccountExist = db.userAccounts.Any(a => a.Account_No == accountNo);

        if (isAccountExist)
        {
            MessageBox.Show("Số tài khoản đã tồn tại. Vui lòng chọn số tài khoản khác.");
            return;
        }

        // Khai báo và khởi tạo biến acc
        userAccount acc = new userAccount();
        
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

        // Tiếp tục xử lý và lưu dữ liệu vào cơ sở dữ liệu
        acc.Account_No = accountNo;
        acc.Name = txtname.Text;
        acc.DOB = dateTimePicker1.Value.ToString();
        acc.PhoneNo = txtphone.Text;
        acc.Address = txtaddress.Text;
        acc.State = cbtxtstate.SelectedItem?.ToString();
        acc.Gender = gender;
        acc.maritial_status = m_status;
        acc.balance = Convert.ToDecimal(txtbalance.Text);
        acc.Picture = ms.ToArray();
        db.userAccounts.Add(acc);
        db.SaveChanges();
        MessageBox.Show("Đã Lưu Tài Khoản");
    }
        }
        private bool ValidateData()
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên.");
                return false;
            }

            if (string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return false;
            }

            if (!long.TryParse(txtphone.Text, out long phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                txtphone.Text = string.Empty;
                return false;
            }

            if (string.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                return false;
            }

            if (string.IsNullOrEmpty(txtbalance.Text))
            {
                MessageBox.Show("Vui lòng nhập số dư tài khoản.");
                return false;
            }

            if (!decimal.TryParse(txtbalance.Text, out decimal balance))
            {
                MessageBox.Show("Số dư tài khoản không hợp lệ. Vui lòng nhập lại.");
                txtbalance.Text = string.Empty;
                return false;
            }

            // Kiểm tra trạng thái hôn nhân
            if (!unmarriedradio.Checked && !marriedradio.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái hôn nhân.");
                return false;
            }

            // Kiểm tra giới tính
            if (!maleradio.Checked && !femaleradio.Checked && !otherradio.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return false;
            }

            // Kiểm tra trường hình ảnh
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh.");
                return false;
            }
            if (string.IsNullOrEmpty(cbtxtstate.Text))
            {
                MessageBox.Show("Vui lòng nhập số khu vực.");
                return false;
            }


            return true;
        }
    }
}
