using System;
using System.Windows.Forms;

namespace _Service_Charge_Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra Đơn giá
            if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ (số lớn hơn hoặc bằng 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // 2. Kiểm tra Số lượng
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách hợp lệ (số nguyên không âm)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // 3. Kiểm tra % Giảm giá
            double phanTramGiam = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!double.TryParse(txtGiamGia.Text.Trim(), out phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
                {
                    MessageBox.Show("Phần trăm giảm giá phải từ 0 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamGia.Focus();
                    return;
                }
            }

            // 4. Tính toán kết quả
            double tongTien = (donGia * soLuong) * (100 - phanTramGiam) / 100;

            // 5. Hiển thị kết quả
            lblTongTien.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "0 VNĐ";
            txtDonGia.Focus();
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

    }
}