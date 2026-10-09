namespace ITSupportTicketForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            gbThongTin = new GroupBox();
            txtNguoiYeuCau = new TextBox();
            txtMaPhieu = new TextBox();
            dtpNgayGhiNhan = new DateTimePicker();
            rdoThap = new RadioButton();
            rdoTrungBinh = new RadioButton();
            rdoKhanCap = new RadioButton();
            gbChiTiet = new GroupBox();
            label1 = new Label();
            chkMayTinhBan = new CheckBox();
            chkLaptop = new CheckBox();
            cboLoaiSuCo = new ComboBox();
            btnTaiAnh = new Button();
            chkMayIn = new CheckBox();
            picAnhLoi = new PictureBox();
            chkDienThoai = new CheckBox();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            gbThongTin.SuspendLayout();
            gbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(201, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(218, 31);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Tiếp Nhận Sự Cố IT";
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(txtNguoiYeuCau);
            gbThongTin.Controls.Add(txtMaPhieu);
            gbThongTin.Controls.Add(dtpNgayGhiNhan);
            gbThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbThongTin.Location = new Point(17, 57);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(749, 129);
            gbThongTin.TabIndex = 1;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin phiếu yêu cầu";
            gbThongTin.Enter += gbThongTin_Enter;
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(28, 80);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.PlaceholderText = "Nguyen Van A";
            txtNguoiYeuCau.Size = new Size(238, 27);
            txtNguoiYeuCau.TabIndex = 17;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(28, 37);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.PlaceholderText = "123456";
            txtMaPhieu.Size = new Size(238, 27);
            txtMaPhieu.TabIndex = 2;
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayGhiNhan.Location = new Point(348, 37);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(250, 27);
            dtpNgayGhiNhan.TabIndex = 3;
            // 
            // rdoThap
            // 
            rdoThap.AutoSize = true;
            rdoThap.Location = new Point(203, 74);
            rdoThap.Name = "rdoThap";
            rdoThap.Size = new Size(63, 24);
            rdoThap.TabIndex = 4;
            rdoThap.Text = "Thấp";
            rdoThap.UseVisualStyleBackColor = true;
            // 
            // rdoTrungBinh
            // 
            rdoTrungBinh.AutoSize = true;
            rdoTrungBinh.Checked = true;
            rdoTrungBinh.Location = new Point(203, 114);
            rdoTrungBinh.Name = "rdoTrungBinh";
            rdoTrungBinh.Size = new Size(100, 24);
            rdoTrungBinh.TabIndex = 5;
            rdoTrungBinh.TabStop = true;
            rdoTrungBinh.Text = "Trung bình";
            rdoTrungBinh.UseVisualStyleBackColor = true;
            // 
            // rdoKhanCap
            // 
            rdoKhanCap.AutoSize = true;
            rdoKhanCap.Location = new Point(203, 152);
            rdoKhanCap.Name = "rdoKhanCap";
            rdoKhanCap.Size = new Size(91, 24);
            rdoKhanCap.TabIndex = 6;
            rdoKhanCap.Text = "Khẩn cấp";
            rdoKhanCap.UseVisualStyleBackColor = true;
            // 
            // gbChiTiet
            // 
            gbChiTiet.Controls.Add(label1);
            gbChiTiet.Controls.Add(chkMayTinhBan);
            gbChiTiet.Controls.Add(chkLaptop);
            gbChiTiet.Controls.Add(cboLoaiSuCo);
            gbChiTiet.Controls.Add(btnTaiAnh);
            gbChiTiet.Controls.Add(chkMayIn);
            gbChiTiet.Controls.Add(rdoKhanCap);
            gbChiTiet.Controls.Add(picAnhLoi);
            gbChiTiet.Controls.Add(rdoTrungBinh);
            gbChiTiet.Controls.Add(chkDienThoai);
            gbChiTiet.Controls.Add(rdoThap);
            gbChiTiet.Location = new Point(17, 192);
            gbChiTiet.Name = "gbChiTiet";
            gbChiTiet.Size = new Size(749, 194);
            gbChiTiet.TabIndex = 7;
            gbChiTiet.TabStop = false;
            gbChiTiet.Text = "Phân loại và Chi tiết sự cố";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 15;
            label1.Text = "Chọn loại sự cố";
            // 
            // chkMayTinhBan
            // 
            chkMayTinhBan.AutoSize = true;
            chkMayTinhBan.Location = new Point(28, 74);
            chkMayTinhBan.Name = "chkMayTinhBan";
            chkMayTinhBan.Size = new Size(117, 24);
            chkMayTinhBan.TabIndex = 9;
            chkMayTinhBan.Text = "Máy tính bàn";
            chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(28, 104);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 10;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // cboLoaiSuCo
            // 
            cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Location = new Point(28, 26);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(207, 28);
            cboLoaiSuCo.TabIndex = 8;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(529, 150);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 14;
            btnTaiAnh.Text = "\"Tải ảnh lỗi...\"";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(28, 134);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(75, 24);
            chkMayIn.TabIndex = 11;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            // 
            // picAnhLoi
            // 
            picAnhLoi.BackColor = SystemColors.ControlLight;
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(481, 44);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(165, 84);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 13;
            picAnhLoi.TabStop = false;
            picAnhLoi.Click += picAnhLoi_Click;
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(28, 164);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 12;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // btnGuiYeuCau
            // 
            btnGuiYeuCau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuiYeuCau.Location = new Point(448, 393);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(143, 29);
            btnGuiYeuCau.TabIndex = 15;
            btnGuiYeuCau.Text = "\"Gửi Yêu Cầu\"";
            btnGuiYeuCau.UseVisualStyleBackColor = true;
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(241, 394);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(94, 29);
            btnNhapLai.TabIndex = 16;
            btnNhapLai.Text = "\"Nhập lại\"";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(gbChiTiet);
            Controls.Add(gbThongTin);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống tiếp nhận và phân tích sự cố IT";
            Load += Form1_Load;
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbChiTiet.ResumeLayout(false);
            gbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox gbThongTin;
        private TextBox txtMaPhieu;
        private DateTimePicker dtpNgayGhiNhan;
        private RadioButton rdoThap;
        private RadioButton rdoTrungBinh;
        private RadioButton rdoKhanCap;
        private GroupBox gbChiTiet;
        private ComboBox cboLoaiSuCo;
        private CheckBox chkMayTinhBan;
        private CheckBox chkLaptop;
        private CheckBox chkMayIn;
        private CheckBox chkDienThoai;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;
        private TextBox txtNguoiYeuCau;
        private Label label1;
    }
}
