namespace _Service_Charge_Calculator_
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            lblTongTien = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Đơn giá dịch vụ: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 60);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Số lượng khách: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 92);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã giảm giá: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 154);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 3;
            label4.Text = "Tổng tiền thanh toán: ";
  
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(200, 33);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(200, 66);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(200, 99);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(125, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(213, 147);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(69, 28);
            lblTongTien.TabIndex = 7;
            lblTongTien.Text = "0 VNĐ";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(41, 209);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(94, 29);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(200, 209);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(lblTongTien);
            Controls.Add(txtGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính cước dịch vụ và giảm giá";
 
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Label lblTongTien;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}
