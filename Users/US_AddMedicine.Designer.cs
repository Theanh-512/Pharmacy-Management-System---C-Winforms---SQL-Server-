namespace LongChauPharmacy.Users
{
    partial class US_AddMedicine
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TextBox txtMid;
        private Guna.UI2.WinForms.Guna2TextBox txtMname;
        private Guna.UI2.WinForms.Guna2TextBox txtUnit;
        private Guna.UI2.WinForms.Guna2TextBox txtMnumber;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEDate;
        private Guna.UI2.WinForms.Guna2TextBox txtStock;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicine;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_AddMedicine));
            this.txtMid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpMDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMedicine = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMid
            // 
            this.txtMid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMid.DefaultText = "";
            this.txtMid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMid.Location = new System.Drawing.Point(33, 34);
            this.txtMid.Name = "txtMid";
            this.txtMid.PlaceholderText = "Mã thuốc";
            this.txtMid.SelectedText = "";
            this.txtMid.Size = new System.Drawing.Size(200, 30);
            this.txtMid.TabIndex = 1;
            // 
            // txtMname
            // 
            this.txtMname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMname.DefaultText = "";
            this.txtMname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMname.Location = new System.Drawing.Point(33, 93);
            this.txtMname.Name = "txtMname";
            this.txtMname.PlaceholderText = "Tên thuốc";
            this.txtMname.SelectedText = "";
            this.txtMname.Size = new System.Drawing.Size(200, 30);
            this.txtMname.TabIndex = 2;
            // 
            // txtUnit
            // 
            this.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnit.DefaultText = "";
            this.txtUnit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(283, 34);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PlaceholderText = "Đơn vị";
            this.txtUnit.SelectedText = "";
            this.txtUnit.Size = new System.Drawing.Size(200, 30);
            this.txtUnit.TabIndex = 3;
            // 
            // txtMnumber
            // 
            this.txtMnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMnumber.DefaultText = "";
            this.txtMnumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnumber.Location = new System.Drawing.Point(33, 152);
            this.txtMnumber.Name = "txtMnumber";
            this.txtMnumber.PlaceholderText = "Số lô";
            this.txtMnumber.SelectedText = "";
            this.txtMnumber.Size = new System.Drawing.Size(200, 30);
            this.txtMnumber.TabIndex = 4;
            // 
            // dtpMDate
            // 
            this.dtpMDate.Checked = true;
            this.dtpMDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.dtpMDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpMDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMDate.Location = new System.Drawing.Point(538, 66);
            this.dtpMDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMDate.Name = "dtpMDate";
            this.dtpMDate.Size = new System.Drawing.Size(184, 30);
            this.dtpMDate.TabIndex = 5;
            this.dtpMDate.Value = new System.DateTime(2025, 10, 15, 23, 53, 15, 788);
            this.dtpMDate.ValueChanged += new System.EventHandler(this.dtpMDate_ValueChanged);
            // 
            // dtpEDate
            // 
            this.dtpEDate.Checked = true;
            this.dtpEDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(166)))), ((int)(((byte)(101)))));
            this.dtpEDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEDate.Location = new System.Drawing.Point(538, 152);
            this.dtpEDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(184, 30);
            this.dtpEDate.TabIndex = 6;
            this.dtpEDate.Value = new System.DateTime(2025, 10, 15, 23, 53, 20, 796);
            // 
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.DefaultText = "";
            this.txtStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(283, 93);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "Số lượng";
            this.txtStock.SelectedText = "";
            this.txtStock.Size = new System.Drawing.Size(200, 30);
            this.txtStock.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(283, 152);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Giá bán";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(200, 30);
            this.txtPrice.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(790, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMedicine
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicine.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicine.Location = new System.Drawing.Point(19, 127);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.RowHeadersVisible = false;
            this.dgvMedicine.Size = new System.Drawing.Size(686, 334);
            this.dgvMedicine.TabIndex = 10;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMedicine.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvMedicine.ThemeStyle.ReadOnly = false;
            this.dgvMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicine.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(534, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngày sản xuất";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(534, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày hết hạn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.label8.Location = new System.Drawing.Point(626, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 51);
            this.label8.TabIndex = 19;
            this.label8.Text = "Thêm thuốc mới";
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
            this.guna2CustomGradientPanel1.TabIndex = 28;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMid);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnAdd);
            this.guna2CustomGradientPanel3.Controls.Add(this.label2);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtPrice);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtUnit);
            this.guna2CustomGradientPanel3.Controls.Add(this.dtpMDate);
            this.guna2CustomGradientPanel3.Controls.Add(this.label1);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtStock);
            this.guna2CustomGradientPanel3.Controls.Add(this.dtpEDate);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMname);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMnumber);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(154)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(3, 486);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(964, 211);
            this.guna2CustomGradientPanel3.TabIndex = 30;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(696, 192);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(271, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
            // 
            // US_AddMedicine
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "US_AddMedicine";
            this.Size = new System.Drawing.Size(970, 700);
            this.Load += new System.EventHandler(this.US_AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
