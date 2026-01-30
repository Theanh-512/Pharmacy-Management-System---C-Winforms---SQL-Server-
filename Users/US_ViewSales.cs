using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace LongChauPharmacy.Users
{
    public partial class US_ViewSales : UserControl
    {
        Model1 db = new Model1();
        int currentSaleId = -1;

        public US_ViewSales()
        {
            InitializeComponent();
            LoadSales();
        }

        // === Tải danh sách hóa đơn ===
        private void LoadSales()
        {
            dgvSales.DataSource = db.Sales
                .Select(s => new
                {
                    s.SaleID,
                    s.SaleDate,
                    s.TotalAmount
                })
                .OrderByDescending(s => s.SaleDate)
                .ToList();
        }

        // === Lọc hóa đơn theo khoảng thời gian ===
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFilterFrom.Value.Date;
            DateTime to = dtpFilterTo.Value.Date.AddDays(1);

            dgvSales.DataSource = db.Sales
                .Where(s => s.SaleDate >= from && s.SaleDate < to)
                .Select(s => new
                {
                    s.SaleID,
                    s.SaleDate,
                    s.TotalAmount
                })
                .OrderByDescending(s => s.SaleDate)
                .ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadSales();
        }

        // === Khi chọn hóa đơn trong danh sách ===
        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            currentSaleId = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells["SaleID"].Value);
            var sale = db.Sales.FirstOrDefault(s => s.SaleID == currentSaleId);
            if (sale == null) return;

            // === Hiển thị thông tin khách hàng ===
            var customer = db.Customers.FirstOrDefault(c => c.Id == sale.CustomerID);
            if (customer != null)
            {
                txtFullName.Text = customer.FullName;
                txtPhone.Text = customer.Phone;
                txtAddress.Text = customer.Address;
                txtGender.Text = customer.Gender;
                txtDob.Text = customer.Dob?.ToString("dd/MM/yyyy");
            }
            else
            {
                txtFullName.Text = txtPhone.Text = txtAddress.Text = txtGender.Text = txtDob.Text = "";
            }

            // === Hiển thị thông tin nhân viên và tổng tiền ===
            txtEmployee.Text = db.Users.FirstOrDefault(u => u.Id == sale.UserID)?.name ?? "Không rõ";
            txtTotal.Text = sale.TotalAmount.HasValue ? sale.TotalAmount.Value.ToString("N0") + " đ" : "0 đ";

            // === Hiển thị chi tiết thuốc ===
            dgvDetails.DataSource = db.SaleDetails
                .Where(d => d.SaleID == sale.SaleID)
                .Select(d => new
                {
                    Mã_thuốc = d.mid,
                    Tên_thuốc = db.Medics.Where(m => m.mid == d.mid)
                                         .Select(m => m.mname)
                                         .FirstOrDefault(),
                    Số_lượng = d.Quantity,
                    Đơn_giá = d.Price,
                    Thành_tiền = d.Quantity * d.Price
                })
                .ToList();
        }

        // === Xuất hóa đơn ra PDF ===
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (currentSaleId == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sale = db.Sales.FirstOrDefault(s => s.SaleID == currentSaleId);
            if (sale == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customer = db.Customers.FirstOrDefault(c => c.Id == sale.CustomerID);
            var details = db.SaleDetails.Where(d => d.SaleID == sale.SaleID).ToList();

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                FileName = $"HoaDon_{sale.SaleID}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                    {
                        // === Tạo document PDF ===
                        Document doc = new Document(PageSize.A4, 36, 36, 54, 54);
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        // === Font tiếng Việt (Unicode) ===
                        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                        BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                        // === Tiêu đề ===
                        Paragraph title = new Paragraph("💊 NHÀ THUỐC LONG CHÂU\n\nHÓA ĐƠN BÁN THUỐC\n\n", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title);

                        // === Thông tin chung ===
                        Paragraph info = new Paragraph(
                            $"Mã hóa đơn: HD{sale.SaleID:0000}\n" +
                            $"Ngày bán: {sale.SaleDate:dd/MM/yyyy HH:mm}\n" +
                            $"Khách hàng: {(customer != null ? customer.FullName : "Khách lẻ")}\n" +
                            $"SĐT: {(customer != null ? customer.Phone : "-")}\n" +
                            $"Địa chỉ: {(customer != null ? customer.Address : "-")}\n" +
                            $"Nhân viên bán: {txtEmployee.Text}\n\n",
                            normalFont
                        );
                        doc.Add(info);

                        // === Bảng chi tiết ===
                        PdfPTable table = new PdfPTable(5);
                        table.WidthPercentage = 100;
                        table.SetWidths(new float[] { 2f, 4f, 2f, 2f, 2f });

                        string[] headers = { "Mã thuốc", "Tên thuốc", "Số lượng", "Đơn giá", "Thành tiền" };
                        foreach (var h in headers)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(h, headerFont))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                BackgroundColor = new BaseColor(230, 230, 250)
                            };
                            table.AddCell(cell);
                        }

                        foreach (var d in details)
                        {
                            var med = db.Medics.FirstOrDefault(m => m.mid == d.mid);
                            string tenThuoc = med?.mname ?? "(Không rõ)";
                            table.AddCell(new Phrase(d.mid, normalFont));
                            table.AddCell(new Phrase(tenThuoc, normalFont));
                            table.AddCell(new Phrase(d.Quantity.ToString(), normalFont));
                            table.AddCell(new Phrase(d.Price.ToString("N0") + " đ", normalFont));
                            table.AddCell(new Phrase((d.Quantity * d.Price).ToString("N0") + " đ", normalFont));
                        }

                        doc.Add(table);

                        // === Tổng cộng ===
                        Paragraph total = new Paragraph(
                            $"\nTổng tiền: {sale.TotalAmount:N0} VNĐ\n",
                            headerFont
                        );
                        total.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(total);

                        doc.Close();
                    }

                    MessageBox.Show("Xuất hóa đơn PDF thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(saveDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
