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
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // cboReportType
            // 
            this.cboReportType.BackColor = System.Drawing.Color.Transparent;
            this.cboReportType.BorderRadius = 6;
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
            this.cboReportType.Location = new System.Drawing.Point(36, 42);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Size = new System.Drawing.Size(350, 36);
            this.cboReportType.TabIndex = 3;
            this.cboReportType.SelectedIndexChanged += new System.EventHandler(this.cboReportType_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BorderRadius = 6;
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(154)))), ((int)(((byte)(230)))));
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(443, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 40);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Tải báo cáo";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.Color.Transparent;
            this.cboMonth.BorderRadius = 6;
            this.cboMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FocusedColor = System.Drawing.Color.Empty;
            this.cboMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMonth.ForeColor = System.Drawing.Color.Black;
            this.cboMonth.ItemHeight = 30;
            this.cboMonth.Location = new System.Drawing.Point(613, 42);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(120, 36);
            this.cboMonth.TabIndex = 1;
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.Transparent;
            this.cboYear.BorderRadius = 6;
            this.cboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FocusedColor = System.Drawing.Color.Empty;
            this.cboYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboYear.ForeColor = System.Drawing.Color.Black;
            this.cboYear.ItemHeight = 30;
            this.cboYear.Location = new System.Drawing.Point(772, 42);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(120, 36);
            this.cboYear.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(970, 581);
            this.reportViewer1.TabIndex = 4;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(964, 110);
            this.guna2CustomGradientPanel2.TabIndex = 19;
            // 
            // UC_Report
            // 
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboReportType);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(970, 700);
            this.Load += new System.EventHandler(this.UC_Report_Load);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
    }
}
