using PharmacyDB.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Users
{
    public partial class US_MedicInfo : UserControl
    {
        private readonly Model1 db = new Model1();
        private bool isSyncing = false; // tránh vòng lặp giữa dgv và combo

        public US_MedicInfo()
        {
            InitializeComponent();
        }

        private void US_MedicInfo_Load(object sender, EventArgs e)
        {
            LoadMedicList();
            LoadComboBoxMedic();
            lblCurrentMedic.Text = "Hiện tại đang chọn: -";
        }

        // ======================
        //  LOAD DỮ LIỆU
        // ======================
        private void LoadMedicList()
        {
            var list = db.Medics.Select(m => new
            {
                m.Id,
                Tên_Thuốc = m.mname,
                Đơn_Vị = m.unit,
                Giá_Bán = m.salePrice
            }).ToList();

            dgvMedic.DataSource = list;
        }

        private void LoadComboBoxMedic()
        {
            cmbMedicineList.SelectedIndexChanged -= cmbMedicineList_SelectedIndexChanged; // 🚫 tạm ngắt

            var medics = db.Medics
                .Select(m => new MedicItem { Id = m.Id, Name = m.mname })
                .ToList();

            cmbMedicineList.DataSource = medics;
            cmbMedicineList.DisplayMember = "Name";
            cmbMedicineList.ValueMember = "Id";
            cmbMedicineList.SelectedIndex = -1;

            cmbMedicineList.SelectedIndexChanged += cmbMedicineList_SelectedIndexChanged; // ✅ bật lại
        }

        // ======================
        //  HIỂN THỊ THÔNG TIN THUỐC
        // ======================
        private void LoadInfo(int medicId)
        {
            var info = db.InfoMedics.FirstOrDefault(i => i.MedicId == medicId);
            var medicName = db.Medics.Where(m => m.Id == medicId).Select(m => m.mname).FirstOrDefault();

            lblCurrentMedic.Text = $"{medicName ?? "-"}";

            if (info != null)
            {
                txtChiDinh.Text = info.ChiDinh;
                txtChongChiDinh.Text = info.ChongChiDinh;
                txtHinhAnhPath.Text = info.HinhAnh;

                if (!string.IsNullOrEmpty(info.HinhAnh) && File.Exists(info.HinhAnh))
                    picThuoc.Image = Image.FromFile(info.HinhAnh);
                else
                    picThuoc.Image = null;
            }
            else
            {
                txtChiDinh.Clear();
                txtChongChiDinh.Clear();
                txtHinhAnhPath.Clear();
                picThuoc.Image = null;
            }
        }

        // ======================
        //  SỰ KIỆN DGV
        // ======================
        private void dgvMedic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !isSyncing)
            {
                isSyncing = true;
                int medicId = Convert.ToInt32(dgvMedic.Rows[e.RowIndex].Cells["Id"].Value);
                LoadInfo(medicId);

                // đồng bộ ComboBox
                cmbMedicineList.SelectedValue = medicId;
                isSyncing = false;
            }
        }

        // ======================
        //  SỰ KIỆN COMBOBOX
        // ======================
        private void cmbMedicineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSyncing) return; // tránh vòng lặp đồng bộ
            if (cmbMedicineList.SelectedValue == null) return; // chưa có dữ liệu

            // kiểm tra kiểu dữ liệu an toàn
            if (cmbMedicineList.SelectedValue is int medicId)
            {
                isSyncing = true;
                LoadInfo(medicId);

                // đồng bộ DataGridView
                foreach (DataGridViewRow row in dgvMedic.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Id"].Value) == medicId)
                    {
                        row.Selected = true;
                        dgvMedic.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
                isSyncing = false;
            }
        }

        // ======================
        //  NÚT LƯU & CHỌN ẢNH
        // ======================
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (dgvMedic.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc cần lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int medicId = Convert.ToInt32(dgvMedic.CurrentRow.Cells["Id"].Value);

            var info = db.InfoMedics.FirstOrDefault(i => i.MedicId == medicId);
            if (info == null)
            {
                info = new InfoMedic { MedicId = medicId };
                db.InfoMedics.Add(info);
            }

            info.ChiDinh = txtChiDinh.Text;
            info.ChongChiDinh = txtChongChiDinh.Text;
            info.HinhAnh = txtHinhAnhPath.Text;

            db.SaveChanges();
            MessageBox.Show("✅ Cập nhật thông tin thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Ảnh thuốc (*.jpg;*.png)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtHinhAnhPath.Text = ofd.FileName;
                    picThuoc.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        // ======================
        //  CLASS PHỤ TRỢ
        // ======================
        private class MedicItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
