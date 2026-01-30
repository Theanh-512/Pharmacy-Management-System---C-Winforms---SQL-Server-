using LongChauPharmacy.Admin;
using LongChauPharmacy.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongChauPharmacy
{
    public partial class UIfrmLogin : Form
    {
        public UIfrmLogin()
        {
            InitializeComponent();
        }

        private void UIfrmLogin_Load(object sender, EventArgs e)
        {
            // Kiểm tra thử kết nối EF
            try
            {
                using (var db = new Model1())
                {
                    int count = db.Users.Count();
                    Console.WriteLine($"Kết nối Entity Framework OK - Có {count} tài khoản.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi kết nối Database!\n" + ex.Message,
                    "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên đăng nhập và mật khẩu!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Model1())
                {
                    var acc = db.Users.FirstOrDefault(u => u.username == user && u.pass == pass);

                    if (acc != null)
                    {
                        MessageBox.Show($"Xin chào {acc.name} ({acc.userRole}) 👋",
                            "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (acc.userRole == "Admin")
                        {
                            UIfrmAdmin ad = new UIfrmAdmin();
                            ad.Show();
                        }
                        else
                        {
                            UIfrmUser us = new UIfrmUser();
                            us.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("❌ Sai tên đăng nhập hoặc mật khẩu!",
                            "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập:\n" + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Tạo mới UserControl đăng ký
            UC_Register uc = new UC_Register();
            uc.Size = new Size(600, 470);

            int x = (this.ClientSize.Width - uc.Width) / 2;
            int y = (this.ClientSize.Height - uc.Height) / 2;
            uc.Location = new Point(x, y);

            uc.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnQMK_Click(object sender, EventArgs e)
        {
            // Tao moi quen mat khau
            UC_ReloadPassword uc = new UC_ReloadPassword();
            uc.Size = new Size(600, 470);

            int x = (this.ClientSize.Width - uc.Width) / 2;
            int y = (this.ClientSize.Height - uc.Height) / 2;
            uc.Location = new Point(x, y);

            uc.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            UC_SearchInvoices uc = new UC_SearchInvoices();
            uc.Size = new Size(970, 700 );

            int x = (this.ClientSize.Width - uc.Width) / 2;
            int y = (this.ClientSize.Height - uc.Height) / 2;
            uc.Location = new Point(x, y);

            uc.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
