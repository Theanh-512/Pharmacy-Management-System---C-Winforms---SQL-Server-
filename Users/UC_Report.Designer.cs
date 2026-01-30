namespace LongChauPharmacy.Admin
{
    partial class UC_Report
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2ComboBox cboReportType;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonth;
        private Guna.UI2.WinForms.Guna2ComboBox cboYear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cboReportType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.cboMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // cboReportType
            // 
            this.cboReportType.BackColor = System.Drawing.Color.Transparent;
            this.cboReportType.BorderRadius = 8;
            this.cboReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportType.FocusedColor = System.Drawing.Color.Empty;
            this.cboReportType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboReportType.ForeColor = System.Drawing.Color.Black;
            this.cboReportType.ItemHeight = 30;
            this.cboReportType.Items.AddRange(new object[] {
            "1. Doanh thu theo tháng (tổng + chi tiết)",
            "2. Doanh thu theo nhân viên (theo tháng)",
            "3. Thống kê số lượng bán theo tháng"});
            this.cboReportType.Location = new System.Drawing.Point(26, 33);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Size = new System.Drawing.Size(350, 36);
            this.cboReportType.TabIndex = 3;
            this.cboReportType.SelectedIndexChanged += new System.EventHandler(this.cboReportType_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BorderRadius = 8;
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(386, 33);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 36);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Tải báo cáo";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.Color.Transparent;
            this.cboMonth.BorderRadius = 8;
            this.cboMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FocusedColor = System.Drawing.Color.Empty;
            this.cboMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMonth.ForeColor = System.Drawing.Color.Black;
            this.cboMonth.ItemHeight = 30;
            this.cboMonth.Location = new System.Drawing.Point(520, 33);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(90, 36);
            this.cboMonth.TabIndex = 1;
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.Transparent;
            this.cboYear.BorderRadius = 8;
            this.cboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FocusedColor = System.Drawing.Color.Empty;
            this.cboYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboYear.ForeColor = System.Drawing.Color.Black;
            this.cboYear.ItemHeight = 30;
            this.cboYear.Location = new System.Drawing.Point(620, 33);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(100, 36);
            this.cboYear.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1194, 581);
            this.reportViewer1.TabIndex = 4;
            // 
            // UC_Report
            // 
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboReportType);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(1194, 681);
            this.Load += new System.EventHandler(this.UC_Report_Load);
            this.ResumeLayout(false);

        }
    }
}
