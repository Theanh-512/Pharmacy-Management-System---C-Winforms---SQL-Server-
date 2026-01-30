using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Guna.UI2.WinForms;

namespace LongChauPharmacy.Admin
{
    public partial class UC_Report : UserControl
    {
        // ✅ Chuỗi kết nối database
        private readonly string connectionString = @"Data Source=.;Initial Catalog=PharmacyDB;Integrated Security=True";


        public static class CurrentUser
{
    public static string Username { get; set; }
    public static string FullName { get; set; }
}

        public UC_Report()
        {
            InitializeComponent();
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {
            // ✅ Thiết lập combo tháng & năm
            for (int i = 1; i <= 12; i++) cboMonth.Items.Add(i);
            for (int y = 2023; y <= DateTime.Now.Year; y++) cboYear.Items.Add(y);

            cboMonth.SelectedItem = DateTime.Now.Month;
            cboYear.SelectedItem = DateTime.Now.Year;

            cboReportType.SelectedIndex = 1; // mặc định: Doanh thu theo tháng
        }

        private void cboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ✅ Ẩn/hiện tháng & năm theo loại báo cáo
            bool showTime = cboReportType.SelectedIndex == 0
                         || cboReportType.SelectedIndex == 1
                         || cboReportType.SelectedIndex == 2;
            cboMonth.Visible = showTime;
            cboYear.Visible = showTime;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chi tiết lỗi: " + ex.Message, "Lỗi tải báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReport()
        {
            string basePath = Path.Combine(Application.StartupPath, @"..\..\Reports\");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                switch (cboReportType.SelectedIndex)
                {
                    

                    // 2️⃣ Doanh thu theo tháng (tổng + chi tiết)
                    case 0:
                        int month = Convert.ToInt32(cboMonth.SelectedItem);
                        int year = Convert.ToInt32(cboYear.SelectedItem);
                        LoadMonthlyRevenueReport(conn, basePath, month, year);
                        break;

                    // 3️⃣ Doanh thu theo nhân viên (theo tháng)
                    case 1:
                        int m = Convert.ToInt32(cboMonth.SelectedItem);
                        int y = Convert.ToInt32(cboYear.SelectedItem);
                        LoadSingleDatasetReport(conn,
                            $"SELECT * FROM v_SalesRevenueByUser WHERE [Year] = {y} AND [Month] = {m}",
                            basePath + "rpt_SalesRevenueByUser.rdlc",
                            "DataSet1");
                        break;

                    // 4️⃣ Thống kê số lượng bán theo tháng
                    case 2:
                        int mm = Convert.ToInt32(cboMonth.SelectedItem);
                        int yy = Convert.ToInt32(cboYear.SelectedItem);

                        string queryMedicine = $@"SELECT * FROM v_MedicineSalesByMonth WHERE [Year] = {yy} AND [Month] = {mm}";
                        DataTable dtMedicine = new DataTable();
                        new SqlDataAdapter(queryMedicine, conn).Fill(dtMedicine);

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.ReportPath = basePath + "rpt_MedicineSalesByMonth.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsMedicineSales", dtMedicine));
                        reportViewer1.RefreshReport();
                        break;
                }
            }
        }

        // 🧱 Nạp báo cáo chỉ có 1 dataset
        private void LoadSingleDatasetReport(SqlConnection conn, string query, string reportPath, string datasetName)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = reportPath;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(datasetName, dt));
            reportViewer1.RefreshReport();
        }

        // 🧱 Nạp báo cáo “Doanh thu theo tháng (tổng + chi tiết)”
        private void LoadMonthlyRevenueReport(SqlConnection conn, string basePath, int month, int year)
        {
            string querySummary = $@"
                SELECT * FROM v_SalesRevenueByMonth 
                WHERE [Year] = {year} AND [Month] = {month}";

            string queryDetail = $@"
                SELECT * FROM v_SalesRevenue
                WHERE YEAR(SaleDate) = {year} AND MONTH(SaleDate) = {month}";

            DataTable dtSummary = new DataTable();
            DataTable dtDetail = new DataTable();
            new SqlDataAdapter(querySummary, conn).Fill(dtSummary);
            new SqlDataAdapter(queryDetail, conn).Fill(dtDetail);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = basePath + "rpt_SalesRevenueByMonth_Detail.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsSummary", dtSummary));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsDetail", dtDetail));
            reportViewer1.RefreshReport();
        }

       

    }
}
