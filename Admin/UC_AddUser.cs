using System;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Admin
{
    public partial class UC_AddUser : UserControl
    {
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    string name = txtName.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string mobile = txtMobile.Text.Trim();
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    string role = cmbRole.Text;
                    DateTime dob = dtpDob.Value;

                    if (string.IsNullOrWhiteSpace(name) ||
                        string.IsNullOrWhiteSpace(username) ||
                        string.IsNullOrWhiteSpace(password) ||
                        string.IsNullOrWhiteSpace(role))
                    {
                        MessageBox.Show("⚠️ Vui lòng nhập đầy đủ thông tin bắt buộc!");
                        return;
                    }

                    // Kiểm tra trùng username
                    var exist = db.Users.FirstOrDefault(x => x.username == username);
                    if (exist != null)
                    {
                        MessageBox.Show("❌ Tên đăng nhập đã tồn tại!");
                        return;
                    }

                    // ✅ Đổi tên biến thành newUser
                    User newUser = new User
                    {
                        name = name,
                        email = email,
                        mobile = mobile,
                        username = username,
                        pass = password,
                        userRole = role,
                        dob = dob,
                        CreatedAt = DateTime.Now
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("✅ Thêm nhân viên thành công!");

                    txtName.Clear();
                    txtEmail.Clear();
                    txtMobile.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    cmbRole.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi thêm nhân viên:\n" + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            dtpDob.Value = DateTime.Now;

        }

      
    }
}
