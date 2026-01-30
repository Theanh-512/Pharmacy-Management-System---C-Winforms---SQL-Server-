using System;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Users
{
    public partial class US_AddMedicine : UserControl
    {
        Model1 db = new Model1();

        public US_AddMedicine()
        {
            InitializeComponent();
        }

        private void US_AddMedicine_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvMedicine.DataSource = db.Medics
                .Select(m => new
                {
                    MãThuốc = m.mid,
                    TênThuốc = m.mname,
                    ĐơnVị = m.unit,
                    SốLô = m.mnumber,
                    NgàySX = m.mDate,
                    HSD = m.eDate,
                    TồnKho = m.stock,
                    GiáBán = m.salePrice
                })
                .ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMid.Text) ||
                    string.IsNullOrWhiteSpace(txtMname.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin thuốc!");
                    return;
                }

                Medic m = new Medic()
                {
                    mid = txtMid.Text.Trim(),
                    mname = txtMname.Text.Trim(),
                    unit = txtUnit.Text.Trim(),
                    mnumber = txtMnumber.Text.Trim(),
                    mDate = dtpMDate.Value,
                    eDate = dtpEDate.Value,
                    stock = int.Parse(txtStock.Text.Trim()),
                    salePrice = decimal.Parse(txtPrice.Text.Trim())
                };

                db.Medics.Add(m);
                db.SaveChanges();
                MessageBox.Show("✅ Thêm thuốc thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thuốc: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpMDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
