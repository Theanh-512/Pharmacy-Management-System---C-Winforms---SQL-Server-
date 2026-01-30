using System;
using System.Linq;
using System.Windows.Forms;

namespace LongChauPharmacy.Admin
{
    public partial class UC_ViewCustomer : UserControl
    {
        Model1 db = new Model1();

        public UC_ViewCustomer()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvCustomer.DataSource = db.Customers
                .Select(c => new
                {
                    c.Id,
                    Họ_Tên = c.FullName,
                    Giới_Tính = c.Gender,
                    Ngày_Sinh = c.Dob,
                    SĐT = c.Phone,
                    Địa_Chỉ = c.Address
                })
                .OrderBy(c => c.Họ_Tên)
                .ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var result = db.Customers
                .Where(c => c.FullName.ToLower().Contains(keyword)
                         || c.Phone.Contains(keyword))
                .Select(c => new
                {
                    c.Id,
                    Họ_Tên = c.FullName,
                    Giới_Tính = c.Gender,
                    Ngày_Sinh = c.Dob,
                    SĐT = c.Phone,
                    Địa_Chỉ = c.Address
                })
                .ToList();

            dgvCustomer.DataSource = result;
        }

       

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
