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
    public partial class UIfrmAdmin : Form
    {
        public UIfrmAdmin()
        {
            InitializeComponent();
        }

        private void UIfrmAdmin_Load(object sender, EventArgs e)
        {
            Admin.UC_Dashboard uc = new Admin.UC_Dashboard();
            loadUserControl(uc);
        }

        private void loadUserControl(UserControl uc)
        {
            // Gọi UserControl (nạp vào PanelMain)
            PanelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(uc);
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Admin.UC_Report uc = new Admin.UC_Report();
            loadUserControl(uc);
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btndashboard_Click_1(object sender, EventArgs e)
        {
            Admin.UC_Dashboard uc = new Admin.UC_Dashboard();
            loadUserControl(uc);
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            Admin.UC_AddUser uc = new Admin.UC_AddUser();
            loadUserControl(uc);
        }

        private void btnViewUser_Click_1(object sender, EventArgs e)
        {
            Admin.UC_ViewUser uc = new Admin.UC_ViewUser();
            loadUserControl(uc);
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            Admin.UC_ViewCustomer uc = new Admin.UC_ViewCustomer();
            loadUserControl(uc);
        }

        private void btnRevenue_Click_1(object sender, EventArgs e)
        {
            Admin.UC_Revenue uc = new Admin.UC_Revenue();
            loadUserControl(uc);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UIfrmLogin login = new UIfrmLogin();
            login.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
