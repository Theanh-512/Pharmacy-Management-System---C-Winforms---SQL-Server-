using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongChauPharmacy.Admin
{
    public partial class UC_Register : UserControl
    {
        public UC_Register()
        {
            InitializeComponent();
        }

        private void UC_Register_Load(object sender, EventArgs e)
        {

            if (cmbRole.Items.Count == 0)
            {
                cmbRole.Items.Add("User");
            }
            cmbRole.SelectedIndex = 0;
            cmbRole.Enabled = false;
            cmbRole.Visible = false;
            dtpDob.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mobile = txtMobile.Text.Trim();


            string role = "User";

            DateTime registerDate = dtpDob.Value;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập, Mật khẩu và Xác nhận mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và Mật khẩu xác nhận không khớp!", "Lỗi xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPassword.Clear();
                txtConfirmPassword.Clear();
                return;
            }

            using (var db = new Model1())
            {

                bool exists = db.Users.Any(u => u.username == username);
                if (exists)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var newUser = new User
                {
                    name = name,
                    username = username,
                    pass = password,
                    email = email,
                    mobile = mobile,
                    userRole = role, // Đã gán cố định là "User"
                    dob = dtpDob.Value
                };


                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công! Tài khoản được tạo với quyền User.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}