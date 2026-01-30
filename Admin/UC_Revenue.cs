using System;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Admin
{
    public partial class UC_Revenue : UserControl
    {
        public UC_Revenue()
        {
            InitializeComponent();
        }

        private void UC_Revenue_Load(object sender, EventArgs e)
        {
            // Hiển thị năm hiện tại và 5 năm trước
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= currentYear - 5; i--)
                cmbYear.Items.Add(i.ToString());

            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cmbYear.SelectedIndex = 0;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Vui lòng chọn tháng và năm để xem doanh thu!");
                return;
            }

            int month = int.Parse(cmbMonth.Text);
            int year = int.Parse(cmbYear.Text);

            try
            {
                using (var db = new Model1())
                {
                    // Lọc dữ liệu theo tháng, năm
                    var data = db.Sales
                                 .Where(s => s.SaleDate.HasValue &&
                                             s.SaleDate.Value.Month == month &&
                                             s.SaleDate.Value.Year == year)
                                 .Select(s => new
                                 {
                                     s.SaleID,
                                     s.SaleDate,
                                     NhanVien = s.User.name,
                                     s.TotalAmount
                                 })
                                 .ToList();

                    dgvRevenue.DataSource = data;

                    // ✅ Fix lỗi decimal? (nếu null thì mặc định = 0)
                    decimal total = data.Sum(x => x.TotalAmount ?? 0);
                    lblTotal.Text = $"Tổng doanh thu: {total:N0} VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lấy dữ liệu doanh thu:\n" + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
