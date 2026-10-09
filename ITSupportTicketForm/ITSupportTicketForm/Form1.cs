using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ITSupportTicketForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sự kiện chạy khi Form bắt đầu mở lên
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Khởi tạo danh sách items cho ComboBox Loại sự cố
            cboLoaiSuCo.Items.Clear();
            cboLoaiSuCo.Items.AddRange(new string[] {
                "Phần cứng",
                "Phần mềm",
                "Mạng",
                "Tài khoản"
            });
            cboLoaiSuCo.SelectedIndex = 0; // Chọn item đầu tiên "Phần cứng"

            // 2. Thiết lập cấu hình mặc định cho DateTimePicker
            dtpNgayGhiNhan.Value = DateTime.Now;

            // 3. Đảm bảo trạng thái ban đầu của RadioButton
            rdoTrungBinh.Checked = true;
        }

        /// <summary>
        /// Xử lý nút "Tải ảnh lỗi": Mở hộp thoại chọn tệp hình ảnh
        /// </summary>
        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Cấu hình tiêu đề và bộ lọc định dạng tệp (.jpg, .png)
                openFileDialog.Title = "Chọn hình ảnh mô tả sự cố";
                openFileDialog.Filter = "Định dạng hình ảnh (*.jpg; *.png)|*.jpg;*.png|Tất cả tệp (*.*)|*.*";
                openFileDialog.Multiselect = false; // Chỉ cho phép chọn 1 ảnh

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Đọc ảnh vào MemoryStream rồi clone để tránh khóa (lock) file trên ổ đĩa
                        using (var stream = new MemoryStream(File.ReadAllBytes(openFileDialog.FileName)))
                        {
                            if (picAnhLoi.Image != null)
                            {
                                picAnhLoi.Image.Dispose(); // Giải phóng ảnh cũ nếu có
                            }
                            picAnhLoi.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải hình ảnh! Lỗi: " + ex.Message,
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Xử lý nút "Gửi yêu cầu": Validation và tổng hợp dữ liệu xuất ra MessageBox
        /// </summary>
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // --- BƯỚC 1: KIỂM TRA RÀNG BUỘC ĐẦU VÀO (VALIDATION) ---
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu yêu cầu!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập tên Người yêu cầu!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            // --- BƯỚC 2: THU THẬP DỮ LIỆU TỪ CÁC CONTROL ---

            // A. Lấy giá trị Mức độ ưu tiên từ RadioButton
            string mucDoUuTien = "Trung bình";
            if (rdoThap.Checked)
            {
                mucDoUuTien = "Thấp";
            }
            else if (rdoTrungBinh.Checked)
            {
                mucDoUuTien = "Trung bình";
            }
            else if (rdoKhanCap.Checked)
            {
                mucDoUuTien = "Khẩn cấp";
            }

            // B. Lấy danh sách Thiết bị ảnh hưởng từ CheckBox
            List<string> danhSachThietBi = new List<string>();
            if (chkMayTinhBan.Checked) danhSachThietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) danhSachThietBi.Add("Laptop");
            if (chkMayIn.Checked) danhSachThietBi.Add("Máy in");
            if (chkDienThoai.Checked) danhSachThietBi.Add("Điện thoại");

            string chuoiThietBi = danhSachThietBi.Count > 0
                ? string.Join(", ", danhSachThietBi)
                : "Không chọn thiết bị";

            // C. Lấy Loại sự cố từ ComboBox
            string loaiSuCo = cboLoaiSuCo.SelectedItem != null
                ? cboLoaiSuCo.SelectedItem.ToString()
                : "Chưa phân loại";

            // D. Kiểm tra trạng thái ảnh đính kèm
            string trangThaiAnh = (picAnhLoi.Image != null) ? "Đã tải ảnh lên" : "Không có ảnh";

            // --- BƯỚC 3: TỔNG HỢP VÀ HIỂN THỊ KẾT QUẢ ---
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("==========================================");
            builder.AppendLine("      THÔNG TIN PHIẾU YÊU CẦU BẢO TRÌ IT    ");
            builder.AppendLine("==========================================");
            builder.AppendLine($"• Mã phiếu: {txtMaPhieu.Text.Trim()}");
            builder.AppendLine($"• Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}");
            builder.AppendLine($"• Thời gian ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy HH:mm}");
            builder.AppendLine($"• Mức độ ưu tiên: {mucDoUuTien}");
            builder.AppendLine("------------------------------------------");
            builder.AppendLine($"• Loại sự cố: {loaiSuCo}");
            builder.AppendLine($"• Thiết bị ảnh hưởng: {chuoiThietBi}");
            builder.AppendLine($"• Ảnh đính kèm: {trangThaiAnh}");
            builder.AppendLine("==========================================");

            MessageBox.Show(builder.ToString(), "Xác nhận gửi thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Xử lý nút "Nhập lại": Reset toàn bộ Control về trạng thái ban đầu
        /// </summary>
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            // 1. Xóa nội dung các ô TextBox
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();

            // 2. Cài lại thời gian hiện tại
            dtpNgayGhiNhan.Value = DateTime.Now;

            // 3. Đặt lại Mức độ ưu tiên về "Trung bình"
            rdoTrungBinh.Checked = true;

            // 4. Đặt lại ComboBox về vị trí đầu tiên
            if (cboLoaiSuCo.Items.Count > 0)
            {
                cboLoaiSuCo.SelectedIndex = 0;
            }

            // 5. Bỏ chọn toàn bộ CheckBox
            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            // 6. Xóa ảnh trong PictureBox và giải phóng bộ nhớ
            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }

            // 7. Đặt con trỏ chuột về ô Mã phiếu
            txtMaPhieu.Focus();
        }

        private void gbThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void picAnhLoi_Click(object sender, EventArgs e)
        {

        }
    }
}