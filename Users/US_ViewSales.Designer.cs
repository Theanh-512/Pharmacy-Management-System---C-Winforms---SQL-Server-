namespace LongChauPharmacy.Users
{
    partial class US_ViewSales
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSales;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetails;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnExportPDF;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFilterFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFilterTo;
        private System.Windows.Forms.GroupBox groupCustomer;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtDob;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployee;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSales = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportPDF = new Guna.UI2.WinForms.Guna2Button();
            this.dtpFilterFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFilterTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupCustomer = new System.Windows.Forms.GroupBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtDob = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.groupCustomer.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(166)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(166)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSales.Location = new System.Drawing.Point(17, 17);
            this.dgvSales.Name = "dgvSales";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 72;
            this.dgvSales.Size = new System.Drawing.Size(428, 250);
            this.dgvSales.TabIndex = 4;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSales.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.714286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSales.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSales.ThemeStyle.ReadOnly = false;
            this.dgvSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.714286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSales.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellClick);
            // 
            // dgvDetails
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetails.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetails.Location = new System.Drawing.Point(18, 285);
            this.dgvDetails.Name = "dgvDetails";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowHeadersWidth = 72;
            this.dgvDetails.Size = new System.Drawing.Size(427, 169);
            this.dgvDetails.TabIndex = 6;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.714286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetails.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDetails.ThemeStyle.ReadOnly = false;
            this.dgvDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.714286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetails.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderRadius = 7;
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnFilter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnFilter.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(301, 494);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(140, 40);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseTransparentBackground = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 7;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(166)))), ((int)(((byte)(101)))));
            this.btnReset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(115, 494);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseTransparentBackground = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportPDF.BorderRadius = 7;
            this.btnExportPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnExportPDF.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnExportPDF.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Location = new System.Drawing.Point(303, 494);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(140, 40);
            this.btnExportPDF.TabIndex = 7;
            this.btnExportPDF.Text = "Xuất PDF";
            this.btnExportPDF.UseTransparentBackground = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // dtpFilterFrom
            // 
            this.dtpFilterFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtpFilterFrom.BorderColor = System.Drawing.Color.Transparent;
            this.dtpFilterFrom.BorderRadius = 3;
            this.dtpFilterFrom.Checked = true;
            this.dtpFilterFrom.FillColor = System.Drawing.Color.White;
            this.dtpFilterFrom.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpFilterFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterFrom.Location = new System.Drawing.Point(73, 404);
            this.dtpFilterFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFilterFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFilterFrom.Name = "dtpFilterFrom";
            this.dtpFilterFrom.Size = new System.Drawing.Size(160, 40);
            this.dtpFilterFrom.TabIndex = 0;
            this.dtpFilterFrom.UseTransparentBackground = true;
            this.dtpFilterFrom.Value = new System.DateTime(2025, 10, 16, 23, 2, 5, 213);
            // 
            // dtpFilterTo
            // 
            this.dtpFilterTo.BackColor = System.Drawing.Color.Transparent;
            this.dtpFilterTo.BorderRadius = 3;
            this.dtpFilterTo.Checked = true;
            this.dtpFilterTo.FillColor = System.Drawing.Color.White;
            this.dtpFilterTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterTo.Location = new System.Drawing.Point(281, 404);
            this.dtpFilterTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFilterTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFilterTo.Name = "dtpFilterTo";
            this.dtpFilterTo.Size = new System.Drawing.Size(160, 40);
            this.dtpFilterTo.TabIndex = 1;
            this.dtpFilterTo.UseTransparentBackground = true;
            this.dtpFilterTo.Value = new System.DateTime(2025, 10, 16, 23, 2, 5, 242);
            // 
            // groupCustomer
            // 
            this.groupCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(154)))), ((int)(((byte)(230)))));
            this.groupCustomer.Controls.Add(this.lblFullName);
            this.groupCustomer.Controls.Add(this.txtFullName);
            this.groupCustomer.Controls.Add(this.lblPhone);
            this.groupCustomer.Controls.Add(this.txtPhone);
            this.groupCustomer.Controls.Add(this.lblAddress);
            this.groupCustomer.Controls.Add(this.txtAddress);
            this.groupCustomer.Controls.Add(this.lblGender);
            this.groupCustomer.Controls.Add(this.txtGender);
            this.groupCustomer.Controls.Add(this.lblDob);
            this.groupCustomer.Controls.Add(this.txtDob);
            this.groupCustomer.Controls.Add(this.lblEmployee);
            this.groupCustomer.Controls.Add(this.txtEmployee);
            this.groupCustomer.Controls.Add(this.lblTotal);
            this.groupCustomer.Controls.Add(this.txtTotal);
            this.groupCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupCustomer.Location = new System.Drawing.Point(24, 24);
            this.groupCustomer.Name = "groupCustomer";
            this.groupCustomer.Size = new System.Drawing.Size(417, 348);
            this.groupCustomer.TabIndex = 5;
            this.groupCustomer.TabStop = false;
            this.groupCustomer.Text = "Thông tin khách hàng";
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(43, 39);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 35);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.Location = new System.Drawing.Point(198, 36);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(187, 30);
            this.txtFullName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(43, 81);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(110, 35);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(198, 78);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(187, 30);
            this.txtPhone.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(43, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 35);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(198, 120);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(187, 30);
            this.txtAddress.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(43, 165);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 35);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Giới tính:";
            // 
            // txtGender
            // 
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.DefaultText = "";
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGender.Location = new System.Drawing.Point(198, 162);
            this.txtGender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGender.Name = "txtGender";
            this.txtGender.PlaceholderText = "";
            this.txtGender.ReadOnly = true;
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(187, 30);
            this.txtGender.TabIndex = 7;
            // 
            // lblDob
            // 
            this.lblDob.Location = new System.Drawing.Point(43, 207);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(100, 35);
            this.lblDob.TabIndex = 8;
            this.lblDob.Text = "Ngày sinh:";
            // 
            // txtDob
            // 
            this.txtDob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDob.DefaultText = "";
            this.txtDob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDob.Location = new System.Drawing.Point(198, 204);
            this.txtDob.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDob.Name = "txtDob";
            this.txtDob.PlaceholderText = "";
            this.txtDob.ReadOnly = true;
            this.txtDob.SelectedText = "";
            this.txtDob.Size = new System.Drawing.Size(187, 30);
            this.txtDob.TabIndex = 9;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Location = new System.Drawing.Point(43, 250);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(100, 35);
            this.lblEmployee.TabIndex = 10;
            this.lblEmployee.Text = "Nhân viên:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployee.DefaultText = "";
            this.txtEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployee.Location = new System.Drawing.Point(198, 246);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.PlaceholderText = "";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.SelectedText = "";
            this.txtEmployee.Size = new System.Drawing.Size(187, 30);
            this.txtEmployee.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(43, 290);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 35);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.Location = new System.Drawing.Point(198, 287);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(187, 30);
            this.txtTotal.TabIndex = 13;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.label8);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(964, 102);
            this.guna2CustomGradientPanel1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.label8.Location = new System.Drawing.Point(760, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 51);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hóa đơn";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.dgvSales);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnExportPDF);
            this.guna2CustomGradientPanel2.Controls.Add(this.dgvDetails);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(154)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(15, 116);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(462, 559);
            this.guna2CustomGradientPanel2.TabIndex = 32;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Controls.Add(this.label2);
            this.guna2CustomGradientPanel3.Controls.Add(this.label1);
            this.guna2CustomGradientPanel3.Controls.Add(this.groupCustomer);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnReset);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnFilter);
            this.guna2CustomGradientPanel3.Controls.Add(this.dtpFilterTo);
            this.guna2CustomGradientPanel3.Controls.Add(this.dtpFilterFrom);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(154)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(491, 116);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(462, 559);
            this.guna2CustomGradientPanel3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(243, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // US_ViewSales
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Name = "US_ViewSales";
            this.Size = new System.Drawing.Size(970, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.groupCustomer.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
