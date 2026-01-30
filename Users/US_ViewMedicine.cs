using System;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Users
{
    public partial class US_ViewMedicine : UserControl
    {
        Model1 db = new Model1();

        public US_ViewMedicine()
        {
            InitializeComponent();
            LoadFilterOptions();
            LoadAllMedicines();
        }

        // ===== Load combobox lọc =====
        private void LoadFilterOptions()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Tất cả thuốc");
            cmbFilter.Items.Add("Thuốc sắp hết hạn (< 30 ngày)");
            cmbFilter.Items.Add("Thuốc đã hết hạn");
            cmbFilter.SelectedIndex = 0; // Mặc định chọn "Tất cả"
        }

        // ===== Hiển thị toàn bộ =====
        private void LoadAllMedicines()
        {
            dgvMedicine.DataSource = db.Medics
                .Select(m => new
                {
                    Mã_thuốc = m.mid,
                    Tên_thuốc = m.mname,
                    Đơn_vị = m.unit,
                    Số_lượng = m.stock,
                    Giá_bán = m.salePrice,
                    Ngày_sản_xuất = m.mDate,
                    Hạn_sử_dụng = m.eDate
                })
                .OrderBy(m => m.Tên_thuốc)
                .ToList();
        }

        // ===== Hiển thị theo loại lọc =====
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            DateTime warningDate = today.AddDays(30);

            switch (cmbFilter.SelectedIndex)
            {
                case 0: // Tất cả
                    LoadAllMedicines();
                    break;

                case 1: // Sắp hết hạn
                    dgvMedicine.DataSource = db.Medics
                        .Where(m => m.eDate >= today && m.eDate <= warningDate)
                        .Select(m => new
                        {
                            Mã_thuốc = m.mid,
                            Tên_thuốc = m.mname,
                            Đơn_vị = m.unit,
                            Số_lượng = m.stock,
                            Giá_bán = m.salePrice,
                            Ngày_sản_xuất = m.mDate,
                            Hạn_sử_dụng = m.eDate
                        })
                        .ToList();
                    break;

                case 2: // Hết hạn
                    dgvMedicine.DataSource = db.Medics
                        .Where(m => m.eDate < today)
                        .Select(m => new
                        {
                            Mã_thuốc = m.mid,
                            Tên_thuốc = m.mname,
                            Đơn_vị = m.unit,
                            Số_lượng = m.stock,
                            Giá_bán = m.salePrice,
                            Ngày_sản_xuất = m.mDate,
                            Hạn_sử_dụng = m.eDate
                        })
                        .ToList();
                    break;
            }
        }

        // ===== Tìm kiếm theo tên hoặc mã thuốc =====
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var result = db.Medics
                .Where(m => m.mname.ToLower().Contains(keyword) || m.mid.ToLower().Contains(keyword))
                .Select(m => new
                {
                    Mã_thuốc = m.mid,
                    Tên_thuốc = m.mname,
                    Đơn_vị = m.unit,
                    Số_lượng = m.stock,
                    Giá_bán = m.salePrice,
                    Ngày_sản_xuất = m.mDate,
                    Hạn_sử_dụng = m.eDate
                })
                .ToList();

            dgvMedicine.DataSource = result;
        }

        // ===== Xóa thuốc hết hạn =====
        private void btnDeleteExpired_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            var expired = db.Medics.Where(m => m.eDate < today).ToList();

            if (expired.Count == 0)
            {
                MessageBox.Show("Không có thuốc hết hạn để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Xóa {expired.Count} thuốc đã hết hạn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Medics.RemoveRange(expired);
                db.SaveChanges();
                MessageBox.Show("Đã xóa thuốc hết hạn!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllMedicines();
            }
        }

        private void US_ViewMedicine_Load(object sender, EventArgs e)
        {

        }

        private void dgvMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadAllMedicines();

            txtSearch.Clear();
            cmbFilter.SelectedIndex = 0;

            MessageBox.Show("Đã tải lại danh sách thuốc!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
