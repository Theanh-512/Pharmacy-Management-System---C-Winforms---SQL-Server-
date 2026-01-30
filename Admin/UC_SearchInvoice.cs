using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongChauPharmacy.Users
{
    public partial class UC_SearchInvoices : UserControl
    {
        Model1 db = new Model1();

        public UC_SearchInvoices()
        {
            InitializeComponent();
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // Đăng ký sự kiện cho nút Back
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
        }

        // === NÚT TRỞ VỀ ===
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Tìm form cha (UIfrmLogin)
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Xóa UserControl này khỏi form
                parentForm.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(customerName) && string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên khách hàng hoặc số điện thoại!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var customerQuery = db.Customers.AsQueryable();

                if (!string.IsNullOrEmpty(customerName))
                {
                    customerQuery = customerQuery.Where(c => c.FullName.Contains(customerName));
                }

                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    customerQuery = customerQuery.Where(c => c.Phone.Contains(phoneNumber));
                }

                var customerIds = customerQuery.Select(c => (int?)c.Id).ToList();

                if (customerIds.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("❌ Không tìm thấy khách hàng nào!",
                        "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Lấy danh sách hóa đơn
                var salesData = db.Sales
                    .Where(s => customerIds.Contains(s.CustomerID))
                    .OrderByDescending(s => s.SaleDate)
                    .ToList();

                // Tạo danh sách hiển thị với tên thuốc
                var sales = salesData.Select(s => new
                {
                    MaHoaDon = s.SaleID,
                    TenKhachHang = db.Customers
                        .Where(c => c.Id == s.CustomerID)
                        .Select(c => c.FullName)
                        .FirstOrDefault(),
                    SoDienThoai = db.Customers
                        .Where(c => c.Id == s.CustomerID)
                        .Select(c => c.Phone)
                        .FirstOrDefault(),
                    NgayMua = s.SaleDate,

                    // Lấy danh sách tên thuốc, ngăn cách bằng dấu phẩy
                    ThuocDaMua = string.Join(", ",
                        db.SaleDetails
                            .Where(sd => sd.SaleID == s.SaleID)
                            .Select(sd => db.Medics
                                .Where(m => m.mid == sd.mid)
                                .Select(m => m.mname)
                                .FirstOrDefault())
                            .ToList()),

                    TongTien = s.TotalAmount,
                    NhanVien = db.Users
                        .Where(u => u.Id == s.UserID)
                        .Select(u => u.name)
                        .FirstOrDefault()
                }).ToList();

                if (sales.Count > 0)
                {
                    dataGridView1.DataSource = sales;

                    // Tùy chỉnh hiển thị DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;

                    // Format cột tiền
                    if (dataGridView1.Columns["TongTien"] != null)
                    {
                        dataGridView1.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                        dataGridView1.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    // Format cột ngày
                    if (dataGridView1.Columns["NgayMua"] != null)
                    {
                        dataGridView1.Columns["NgayMua"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }

                    // Cho phép text wrap cho cột thuốc
                    if (dataGridView1.Columns["ThuocDaMua"] != null)
                    {
                        dataGridView1.Columns["ThuocDaMua"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }

                    MessageBox.Show($"✅ Tìm thấy {sales.Count} hóa đơn!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("❌ Khách hàng chưa có hóa đơn nào!",
                        "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi tìm kiếm hóa đơn:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_SearchInvoices_Load(object sender, EventArgs e)
        {

        }
    }
}