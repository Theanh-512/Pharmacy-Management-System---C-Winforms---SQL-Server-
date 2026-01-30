using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LongChauPharmacy.Users
{
    public partial class US_SellMedicine : UserControl
    {
        Model1 db = new Model1();
        List<SaleDetail> cart = new List<SaleDetail>();
        int? currentCustomerId = null;

        public US_SellMedicine()
        {
            InitializeComponent();
        }

        private void US_SellMedicine_Load(object sender, EventArgs e)
        {
            cmbMedicine.DataSource = db.Medics.ToList();
            cmbMedicine.DisplayMember = "mname";
            cmbMedicine.ValueMember = "mid";

            cmbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
        }

        // 🔍 Tìm hoặc thêm khách hàng
        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!", "Cảnh báo");
                return;
            }

            var customer = db.Customers.FirstOrDefault(c => c.Phone == phone);

            if (customer != null)
            {
                currentCustomerId = customer.Id;
                txtFullName.Text = customer.FullName;
                txtAddress.Text = customer.Address;
                cmbGender.Text = customer.Gender;
                dtpDob.Value = customer.Dob ?? DateTime.Now;

                MessageBox.Show($"Đã tìm thấy khách hàng: {customer.FullName}", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Không tìm thấy SĐT này. Bạn có muốn thêm khách hàng mới?",
                    "Thêm mới khách hàng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtFullName.Text))
                    {
                        MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Lỗi");
                        return;
                    }

                    try
                    {
                        Customer newC = new Customer
                        {
                            FullName = txtFullName.Text.Trim(),
                            Phone = phone,
                            Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? "Không rõ" : txtAddress.Text.Trim(),
                            Gender = string.IsNullOrWhiteSpace(cmbGender.Text) ? "Khác" : cmbGender.Text,
                            Dob = dtpDob.Value,
                            CreatedAt = DateTime.Now
                        };

                        db.Customers.Add(newC);
                        db.SaveChanges();
                        currentCustomerId = newC.Id;

                        MessageBox.Show("Đã thêm khách hàng mới thành công!", "Thành công");
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {
                        foreach (var eve in ex.EntityValidationErrors)
                        {
                            foreach (var ve in eve.ValidationErrors)
                            {
                                MessageBox.Show($"Lỗi: {ve.PropertyName} - {ve.ErrorMessage}");
                            }
                        }
                    }
                }
            }
        }

        // ➕ Thêm thuốc vào giỏ
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (cmbMedicine.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc!", "Lỗi");
                return;
            }

            string mid = cmbMedicine.SelectedValue.ToString();
            int qty = (int)numQuantity.Value;

            var med = db.Medics.FirstOrDefault(m => m.mid == mid);
            if (med == null || med.stock < qty)
            {
                MessageBox.Show("Không đủ số lượng tồn!", "Lỗi");
                return;
            }

            cart.Add(new SaleDetail
            {
                mid = mid,
                Quantity = qty,
                Price = med.salePrice
            });

            dgvCart.DataSource = null;
            dgvCart.DataSource = cart.Select(c => new
            {
                Mã_Thuốc = c.mid,
                Số_Lượng = c.Quantity,
                Giá_Bán = c.Price,
                Thành_Tiền = c.Quantity * c.Price
            }).ToList();

            lblTotal.Text = "Tổng: " + cart.Sum(x => x.Quantity * x.Price).ToString("N0") + " VNĐ";
        }

        // 💾 Lưu hóa đơn --> Thanh toán
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentCustomerId == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Cảnh báo");
                return;
            }

            if (!cart.Any())
            {
                MessageBox.Show("Chưa có thuốc trong giỏ!", "Cảnh báo");
                return;
            }

            //  Kiểm tra chống chỉ định trước khi thanh toán (CHỨC NĂNG ĐẶC BIỆT)
            bool hasWarning = false;
            StringBuilder warningMessage = new StringBuilder();

            foreach (var item in cart)
            {
                var med = db.Medics.FirstOrDefault(m => m.mid == item.mid);
                if (med != null)
                {
                    var info = db.InfoMedics.FirstOrDefault(i => i.MedicId == med.Id);

                    if (info != null && !string.IsNullOrWhiteSpace(info.ChongChiDinh))
                    {
                        hasWarning = true;
                        warningMessage.AppendLine($"🔸 {med.mname}: {info.ChongChiDinh}");
                    }
                }
            }

            if (hasWarning)
            {
                DialogResult result = MessageBox.Show(
                    "⚠️ Một số thuốc có chống chỉ định:\n\n" + warningMessage.ToString() +
                    "\n\nBạn có chắc muốn tiếp tục thanh toán?",
                    "Cảnh báo chống chỉ định",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return; // ❌ Người bán chọn dừng lại
            }

            // ✅ 1. Tạo hóa đơn mới
            var sale = new Sale
            {
                CustomerID = currentCustomerId,
                UserID = 2, // giả định nhân viên hiện tại
                SaleDate = DateTime.Now,
                TotalAmount = cart.Sum(x => x.Quantity * x.Price)
            };

            db.Sales.Add(sale);
            db.SaveChanges();

            // ✅ 2. Lưu chi tiết hóa đơn và cập nhật tồn kho
            foreach (var item in cart)
            {
                item.SaleID = sale.SaleID;
                db.SaleDetails.Add(item);

                var med = db.Medics.FirstOrDefault(m => m.mid == item.mid);
                if (med != null)
                {
                    med.stock -= item.Quantity;
                }
            }

            db.SaveChanges();

            // ✅ 3. Xuất PDF
            ExportInvoiceToPDF(sale.SaleID);

            MessageBox.Show("💾 Hóa đơn đã lưu và xuất file PDF thành công!", "Thành công");

            // Reset form
            cart.Clear();
            dgvCart.DataSource = null;
            lblTotal.Text = "Tổng: 0 VNĐ";
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
            currentCustomerId = null;
        }

        private void ExportInvoiceToPDF(int saleId)
        {
            try
            {
                var sale = db.Sales.FirstOrDefault(s => s.SaleID == saleId);
                if (sale == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var customer = db.Customers.FirstOrDefault(c => c.Id == sale.CustomerID);
                var user = db.Users.FirstOrDefault(u => u.Id == sale.UserID);

                var details = db.SaleDetails
                    .Where(d => d.SaleID == saleId)
                    .Join(db.Medics, d => d.mid, m => m.mid, (d, m) => new
                    {
                        m.mname,
                        d.Quantity,
                        d.Price,
                        Total = d.Quantity * d.Price
                    }).ToList();

                string folderPath = @"C:\LongChauPharmacy\Invoices";
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, $"HoaDon_{saleId}.pdf");

                // 🔹 Tạo document
                Document doc = new Document(PageSize.A4, 40f, 40f, 40f, 40f);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // 🧩 Nạp font Unicode hỗ trợ tiếng Việt
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);


                // === Header ===
                Paragraph header = new Paragraph("💊 NHÀ THUỐC LONG CHÂU\n\n", titleFont);
                header.Alignment = Element.ALIGN_CENTER;
                doc.Add(header);

                Paragraph info = new Paragraph(
                    $"Mã hóa đơn: HD{sale.SaleID:0000}\n" +
                    $"Ngày bán: {sale.SaleDate:dd/MM/yyyy HH:mm}\n" +
                    $"Nhân viên: {(user != null ? user.name : "Không xác định")}\n" +
                    $"Khách hàng: {(customer != null ? customer.FullName : "Khách lẻ")}\n" +
                    $"SĐT: {(customer != null ? customer.Phone : "-")}\n" +
                    $"Địa chỉ: {(customer != null ? customer.Address : "-")}\n\n",
                    normalFont
                );
                doc.Add(info);

                // === Bảng chi tiết ===
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 3f, 1f, 2f, 2f });

                table.AddCell(new PdfPCell(new Phrase("Tên thuốc", boldFont)));
                table.AddCell(new PdfPCell(new Phrase("Số lượng", boldFont)));
                table.AddCell(new PdfPCell(new Phrase("Đơn giá", boldFont)));
                table.AddCell(new PdfPCell(new Phrase("Thành tiền", boldFont)));

                foreach (var d in details)
                {
                    table.AddCell(new Phrase(d.mname, normalFont));
                    table.AddCell(new Phrase(d.Quantity.ToString(), normalFont));
                    table.AddCell(new Phrase(d.Price.ToString("N0") + " đ", normalFont));
                    table.AddCell(new Phrase(d.Total.ToString("N0") + " đ", normalFont));
                }

                doc.Add(table);

                // === Tổng cộng ===
                Paragraph total = new Paragraph(
                    $"\nTổng cộng: {sale.TotalAmount:N0} VNĐ\n\nCảm ơn quý khách đã mua hàng tại Long Châu!",
                    boldFont
                );
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Close();

                // 🧾 Mở file PDF sau khi xuất
                if (File.Exists(filePath))
                    System.Diagnostics.Process.Start(filePath);
                else
                    MessageBox.Show("Không tìm thấy file PDF vừa tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }


    }

