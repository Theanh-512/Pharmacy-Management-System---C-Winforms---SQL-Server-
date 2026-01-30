using System;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Admin
{
    public partial class UC_ReloadPassword : UserControl
    {
        public UC_ReloadPassword()
        {
            InitializeComponent();
        }

        private void btnDangnhaplai_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirmPassword.Text.Trim();

            // ⚠️ Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập, Email và Số điện thoại!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới và xác nhận lại!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!",
                    "Lỗi xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                return;
            }

            try
            {
                using (var db = new Model1())
                {
                    // 🔍 Kiểm tra username, email và số điện thoại có khớp không
                    var user = db.Users.FirstOrDefault(u =>
                        u.username == username &&
                        u.email == email &&
                        u.mobile == mobile);  // ⚠️ Chú ý: cột này trong DB phải là "phone" hoặc "mobile"

                    if (user == null)
                    {
                        MessageBox.Show("Tên đăng nhập, Email hoặc Số điện thoại không chính xác!",
                            "Không tìm thấy người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 🔄 Cập nhật mật khẩu mới
                    user.pass = password;
                    db.SaveChanges();

                    MessageBox.Show("Cập nhật mật khẩu thành công! Vui lòng đăng nhập lại.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔙 Quay lại form đăng nhập
                    this.Parent.Controls.Remove(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật mật khẩu!\n" + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            // 🔙 Trở về form đăng nhập
            this.Parent.Controls.Remove(this);
        }
    }
}
