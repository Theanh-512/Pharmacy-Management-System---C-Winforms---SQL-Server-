using System;
using System.Windows.Forms;

namespace LongChauPharmacy.Users
{
    partial class US_MedicInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cmbMedicineList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvMedic = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtHinhAnhPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.picThuoc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtChongChiDinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtChiDinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrentMedic = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedic)).BeginInit();
            this.guna2CustomGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThuoc)).BeginInit();
            this.SuspendLayout();
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
            this.guna2CustomGradientPanel1.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.label8.Location = new System.Drawing.Point(455, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(478, 51);
            this.label8.TabIndex = 19;
            this.label8.Text = "Chỉ định / Chống chỉ định";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Controls.Add(this.cmbMedicineList);
            this.guna2CustomGradientPanel3.Controls.Add(this.dgvMedic);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(154)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(3, 111);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(371, 575);
            this.guna2CustomGradientPanel3.TabIndex = 32;
            // 
            // cmbMedicineList
            // 
            this.cmbMedicineList.BackColor = System.Drawing.Color.Transparent;
            this.cmbMedicineList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMedicineList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicineList.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMedicineList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMedicineList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMedicineList.ItemHeight = 30;
            this.cmbMedicineList.Location = new System.Drawing.Point(16, 491);
            this.cmbMedicineList.Name = "cmbMedicineList";
            this.cmbMedicineList.Size = new System.Drawing.Size(339, 36);
            this.cmbMedicineList.TabIndex = 8;
            this.cmbMedicineList.SelectedIndexChanged += new System.EventHandler(this.cmbMedicineList_SelectedIndexChanged);
            // 
            // dgvMedic
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMedic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMedic.ColumnHeadersHeight = 24;
            this.dgvMedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedic.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedic.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedic.Location = new System.Drawing.Point(16, 19);
            this.dgvMedic.Name = "dgvMedic";
            this.dgvMedic.RowHeadersVisible = false;
            this.dgvMedic.Size = new System.Drawing.Size(339, 441);
            this.dgvMedic.TabIndex = 0;
            this.dgvMedic.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedic.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedic.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedic.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedic.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedic.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedic.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedic.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedic.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedic.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvMedic.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedic.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedic.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvMedic.ThemeStyle.ReadOnly = false;
            this.dgvMedic.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedic.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedic.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvMedic.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedic.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMedic.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedic.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedic_CellClick);
            //this.dgvMedic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedic_CellContentClick);
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.Controls.Add(this.lblCurrentMedic);
            this.guna2CustomGradientPanel4.Controls.Add(this.label3);
            this.guna2CustomGradientPanel4.Controls.Add(this.label2);
            this.guna2CustomGradientPanel4.Controls.Add(this.label4);
            this.guna2CustomGradientPanel4.Controls.Add(this.btnChonAnh);
            this.guna2CustomGradientPanel4.Controls.Add(this.btnSave);
            this.guna2CustomGradientPanel4.Controls.Add(this.txtHinhAnhPath);
            this.guna2CustomGradientPanel4.Controls.Add(this.picThuoc);
            this.guna2CustomGradientPanel4.Controls.Add(this.txtChongChiDinh);
            this.guna2CustomGradientPanel4.Controls.Add(this.txtChiDinh);
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(154)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(380, 111);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(587, 575);
            this.guna2CustomGradientPanel4.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(343, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hình ảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(25, 440);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chống chỉ định";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(25, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Chỉ định ";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.Transparent;
            this.btnChonAnh.BorderRadius = 6;
            this.btnChonAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(166)))), ((int)(((byte)(101)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(396, 189);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(160, 40);
            this.btnChonAnh.TabIndex = 6;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseTransparentBackground = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 6;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(204)))), ((int)(((byte)(195)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(396, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtHinhAnhPath
            // 
            this.txtHinhAnhPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHinhAnhPath.DefaultText = "";
            this.txtHinhAnhPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHinhAnhPath.Location = new System.Drawing.Point(341, 131);
            this.txtHinhAnhPath.Name = "txtHinhAnhPath";
            this.txtHinhAnhPath.PlaceholderText = "Đường dẫn hình ảnh...";
            this.txtHinhAnhPath.SelectedText = "";
            this.txtHinhAnhPath.Size = new System.Drawing.Size(215, 36);
            this.txtHinhAnhPath.TabIndex = 4;
            // 
            // picThuoc
            // 
            this.picThuoc.ImageRotate = 0F;
            this.picThuoc.Location = new System.Drawing.Point(20, 19);
            this.picThuoc.Name = "picThuoc";
            this.picThuoc.Size = new System.Drawing.Size(291, 270);
            this.picThuoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThuoc.TabIndex = 3;
            this.picThuoc.TabStop = false;
            // 
            // txtChongChiDinh
            // 
            this.txtChongChiDinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChongChiDinh.DefaultText = "";
            this.txtChongChiDinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChongChiDinh.Location = new System.Drawing.Point(20, 466);
            this.txtChongChiDinh.Multiline = true;
            this.txtChongChiDinh.Name = "txtChongChiDinh";
            this.txtChongChiDinh.PlaceholderText = "Nhập chống chỉ định...";
            this.txtChongChiDinh.SelectedText = "";
            this.txtChongChiDinh.Size = new System.Drawing.Size(549, 91);
            this.txtChongChiDinh.TabIndex = 2;
            // 
            // txtChiDinh
            // 
            this.txtChiDinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChiDinh.DefaultText = "";
            this.txtChiDinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChiDinh.Location = new System.Drawing.Point(20, 340);
            this.txtChiDinh.Multiline = true;
            this.txtChiDinh.Name = "txtChiDinh";
            this.txtChiDinh.PlaceholderText = "Nhập chỉ định...";
            this.txtChiDinh.SelectedText = "";
            this.txtChiDinh.Size = new System.Drawing.Size(549, 91);
            this.txtChiDinh.TabIndex = 1;
            // 
            // lblCurrentMedic
            // 
            this.lblCurrentMedic.AutoSize = true;
            this.lblCurrentMedic.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentMedic.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCurrentMedic.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentMedic.Location = new System.Drawing.Point(341, 41);
            this.lblCurrentMedic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentMedic.Name = "lblCurrentMedic";
            this.lblCurrentMedic.Size = new System.Drawing.Size(185, 25);
            this.lblCurrentMedic.TabIndex = 23;
            this.lblCurrentMedic.Text = "Sẳn phẩm hiện tại là";
            // 
            // US_MedicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel4);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "US_MedicInfo";
            this.Size = new System.Drawing.Size(970, 700);
            this.Load += new System.EventHandler(this.US_MedicInfo_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedic)).EndInit();
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.guna2CustomGradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgvMedic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedic;
        private Guna.UI2.WinForms.Guna2TextBox txtChiDinh;
        private Guna.UI2.WinForms.Guna2TextBox txtChongChiDinh;
        private Guna.UI2.WinForms.Guna2PictureBox picThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txtHinhAnhPath;
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMedicineList;
        private System.Windows.Forms.Label lblCurrentMedic;
    }
}
