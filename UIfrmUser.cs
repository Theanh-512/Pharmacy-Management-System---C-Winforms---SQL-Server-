using LongChauPharmacy;
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
    public partial class UIfrmUser : Form
    {
        public UIfrmUser()
        {
            InitializeComponent();
        }
        private void OpenChildControl(UserControl uc)
        {
            PanelMain.Controls.Clear(); // Xóa các control cũ trong PanelMain

            uc.Dock = DockStyle.Fill; // Gắn control mới vào
            PanelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void UIfrmUser_Load(object sender, EventArgs e)
        {
            OpenChildControl(new US_Dashboard()); 
        }

        private void btndashboard_Click_1(object sender, EventArgs e)
        {
            OpenChildControl(new US_Dashboard());
        }

        private void btnAddMedicine_Click_1(object sender, EventArgs e)
        {
            OpenChildControl(new US_AddMedicine());
        }

        private void btnViewMedicine_Click_1(object sender, EventArgs e)
        {
            OpenChildControl(new US_ViewMedicine());
        }

        private void btnViewSales_Click_1(object sender, EventArgs e)
        {
            OpenChildControl(new US_ViewSales());
        }

        private void btnSellMedicine_Click_1(object sender, EventArgs e)
        {
            OpenChildControl(new US_SellMedicine());
        }

        private void btnChiDinh_Click_1(object sender, EventArgs e)
        {
            OpenChildControl(new US_MedicInfo());
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UIfrmLogin login = new UIfrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
