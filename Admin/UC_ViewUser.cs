using System;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Admin
{
    public partial class UC_ViewUser : UserControl
    {
        Model1 db = new Model1();
        int currentUserId = -1;

        public UC_ViewUser()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUser.DataSource = db.Users
                .Select(u => new
                {
                    u.Id,
                    Họ_Tên = u.name,
                    Vai_Trò = u.userRole,
                    Ngày_Sinh = u.dob,
                    SĐT = u.mobile,
                    Email = u.email
                })
                .OrderBy(u => u.Họ_Tên)
                .ToList();
        }

        // === Tìm kiếm nhân viên ===
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadUsers();
                return;
            }

            var result = db.Users
                .Where(u =>
                    u.name.ToLower().Contains(keyword) ||
                    u.mobile.Contains(keyword) ||
                    u.userRole.ToLower().Contains(keyword)
                )
                .Select(u => new
                {
                    u.Id,
                    Họ_Tên = u.name,
                    Vai_Trò = u.userRole,
                    Ngày_Sinh = u.dob,
                    SĐT = u.mobile,
                    Email = u.email
                })
                .ToList();

            dgvUser.DataSource = result;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentUserId = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["Id"].Value);
                var user = db.Users.FirstOrDefault(u => u.Id == currentUserId);
                if (user != null)
                {
                    txtName.Text = user.name;
                    txtMobile.Text = user.mobile;
                    txtEmail.Text = user.email;
                    txtRole.Text = user.userRole;
                    dtpDob.Value = user.dob ?? DateTime.Now;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentUserId == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var user = db.Users.FirstOrDefault(u => u.Id == currentUserId);
            if (user != null)
            {
                user.name = txtName.Text.Trim();
                user.mobile = txtMobile.Text.Trim();
                user.email = txtEmail.Text.Trim();
                user.userRole = txtRole.Text.Trim();
                user.dob = dtpDob.Value;

                db.SaveChanges();
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadUsers();
            txtName.Text = txtMobile.Text = txtEmail.Text = txtRole.Text = "";
            dtpDob.Value = DateTime.Now;
            currentUserId = -1;
        }
    }
}
