namespace AppQL
{
    partial class Form_QuanLy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_nhapHang = new System.Windows.Forms.Button();
            this.button_xuatHang = new System.Windows.Forms.Button();
            this.button_tongKetKho = new System.Windows.Forms.Button();
            this.button_loiNhuan = new System.Windows.Forms.Button();
            this.button_logOut = new System.Windows.Forms.Button();
            this.dataGridView_fromDataBase = new System.Windows.Forms.DataGridView();
            this.label_danhSach = new System.Windows.Forms.Label();
            this.button_themPhieuNhap = new System.Windows.Forms.Button();
            this.button_themPhieuXuat = new System.Windows.Forms.Button();
            this.panel_nhapXuat = new System.Windows.Forms.Panel();
            this.label_ngayNhap = new System.Windows.Forms.Label();
            this.label_loaiQua = new System.Windows.Forms.Label();
            this.label_soLuong = new System.Windows.Forms.Label();
            this.label_ID_coSo = new System.Windows.Forms.Label();
            this.label_gia = new System.Windows.Forms.Label();
            this.button_tao = new System.Windows.Forms.Button();
            this.dateTimePicker_nhapXuat = new System.Windows.Forms.DateTimePicker();
            this.comboBox_loaiQua = new System.Windows.Forms.ComboBox();
            this.textBox_ID_coSo = new System.Windows.Forms.TextBox();
            this.numericUpDown_gia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_soLuong = new System.Windows.Forms.NumericUpDown();
            this.button_huyNhapXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fromDataBase)).BeginInit();
            this.panel_nhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // button_nhapHang
            // 
            this.button_nhapHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_nhapHang.BackColor = System.Drawing.Color.Gray;
            this.button_nhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nhapHang.ForeColor = System.Drawing.Color.White;
            this.button_nhapHang.Location = new System.Drawing.Point(13, 12);
            this.button_nhapHang.Name = "button_nhapHang";
            this.button_nhapHang.Size = new System.Drawing.Size(143, 50);
            this.button_nhapHang.TabIndex = 0;
            this.button_nhapHang.Text = "Nhập hàng";
            this.button_nhapHang.UseVisualStyleBackColor = false;
            this.button_nhapHang.Click += new System.EventHandler(this.button_nhapHang_Click);
            // 
            // button_xuatHang
            // 
            this.button_xuatHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_xuatHang.BackColor = System.Drawing.Color.Gray;
            this.button_xuatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xuatHang.ForeColor = System.Drawing.Color.White;
            this.button_xuatHang.Location = new System.Drawing.Point(178, 12);
            this.button_xuatHang.Name = "button_xuatHang";
            this.button_xuatHang.Size = new System.Drawing.Size(143, 50);
            this.button_xuatHang.TabIndex = 1;
            this.button_xuatHang.Text = "Xuất hàng";
            this.button_xuatHang.UseVisualStyleBackColor = false;
            this.button_xuatHang.Click += new System.EventHandler(this.button_xuatHang_Click);
            // 
            // button_tongKetKho
            // 
            this.button_tongKetKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_tongKetKho.BackColor = System.Drawing.Color.Gray;
            this.button_tongKetKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tongKetKho.ForeColor = System.Drawing.Color.White;
            this.button_tongKetKho.Location = new System.Drawing.Point(344, 12);
            this.button_tongKetKho.Name = "button_tongKetKho";
            this.button_tongKetKho.Size = new System.Drawing.Size(143, 50);
            this.button_tongKetKho.TabIndex = 2;
            this.button_tongKetKho.Text = "Tổng kết kho";
            this.button_tongKetKho.UseVisualStyleBackColor = false;
            this.button_tongKetKho.Click += new System.EventHandler(this.button_tongKetKho_Click);
            // 
            // button_loiNhuan
            // 
            this.button_loiNhuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_loiNhuan.BackColor = System.Drawing.Color.Gray;
            this.button_loiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loiNhuan.ForeColor = System.Drawing.Color.White;
            this.button_loiNhuan.Location = new System.Drawing.Point(515, 12);
            this.button_loiNhuan.Name = "button_loiNhuan";
            this.button_loiNhuan.Size = new System.Drawing.Size(143, 50);
            this.button_loiNhuan.TabIndex = 3;
            this.button_loiNhuan.Text = "Lợi nhuận";
            this.button_loiNhuan.UseVisualStyleBackColor = false;
            this.button_loiNhuan.Click += new System.EventHandler(this.button_loiNhuan_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_logOut.BackColor = System.Drawing.Color.Gray;
            this.button_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logOut.ForeColor = System.Drawing.Color.White;
            this.button_logOut.Location = new System.Drawing.Point(687, 12);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(143, 50);
            this.button_logOut.TabIndex = 4;
            this.button_logOut.Text = "Log out";
            this.button_logOut.UseVisualStyleBackColor = false;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // dataGridView_fromDataBase
            // 
            this.dataGridView_fromDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView_fromDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fromDataBase.Location = new System.Drawing.Point(13, 139);
            this.dataGridView_fromDataBase.Name = "dataGridView_fromDataBase";
            this.dataGridView_fromDataBase.Size = new System.Drawing.Size(817, 301);
            this.dataGridView_fromDataBase.TabIndex = 5;
            this.dataGridView_fromDataBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_fromDataBase_CellContentClick);
            // 
            // label_danhSach
            // 
            this.label_danhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_danhSach.AutoSize = true;
            this.label_danhSach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_danhSach.Location = new System.Drawing.Point(12, 110);
            this.label_danhSach.Name = "label_danhSach";
            this.label_danhSach.Size = new System.Drawing.Size(68, 16);
            this.label_danhSach.TabIndex = 6;
            this.label_danhSach.Text = "Danh sách";
            this.label_danhSach.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_themPhieuNhap
            // 
            this.button_themPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_themPhieuNhap.Location = new System.Drawing.Point(687, 81);
            this.button_themPhieuNhap.Name = "button_themPhieuNhap";
            this.button_themPhieuNhap.Size = new System.Drawing.Size(143, 23);
            this.button_themPhieuNhap.TabIndex = 7;
            this.button_themPhieuNhap.Text = "Thêm phiếu nhập";
            this.button_themPhieuNhap.UseVisualStyleBackColor = true;
            this.button_themPhieuNhap.Visible = false;
            this.button_themPhieuNhap.Click += new System.EventHandler(this.button_themPhieuNhap_Click);
            // 
            // button_themPhieuXuat
            // 
            this.button_themPhieuXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_themPhieuXuat.Location = new System.Drawing.Point(687, 110);
            this.button_themPhieuXuat.Name = "button_themPhieuXuat";
            this.button_themPhieuXuat.Size = new System.Drawing.Size(143, 23);
            this.button_themPhieuXuat.TabIndex = 8;
            this.button_themPhieuXuat.Text = "Thêm phiếu xuất";
            this.button_themPhieuXuat.UseVisualStyleBackColor = true;
            this.button_themPhieuXuat.Visible = false;
            this.button_themPhieuXuat.Click += new System.EventHandler(this.button_themPhieuXuat_Click);
            // 
            // panel_nhapXuat
            // 
            this.panel_nhapXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_nhapXuat.BackColor = System.Drawing.Color.White;
            this.panel_nhapXuat.Controls.Add(this.button_huyNhapXuat);
            this.panel_nhapXuat.Controls.Add(this.numericUpDown_soLuong);
            this.panel_nhapXuat.Controls.Add(this.numericUpDown_gia);
            this.panel_nhapXuat.Controls.Add(this.textBox_ID_coSo);
            this.panel_nhapXuat.Controls.Add(this.comboBox_loaiQua);
            this.panel_nhapXuat.Controls.Add(this.dateTimePicker_nhapXuat);
            this.panel_nhapXuat.Controls.Add(this.button_tao);
            this.panel_nhapXuat.Controls.Add(this.label_gia);
            this.panel_nhapXuat.Controls.Add(this.label_ID_coSo);
            this.panel_nhapXuat.Controls.Add(this.label_soLuong);
            this.panel_nhapXuat.Controls.Add(this.label_loaiQua);
            this.panel_nhapXuat.Controls.Add(this.label_ngayNhap);
            this.panel_nhapXuat.Location = new System.Drawing.Point(12, 139);
            this.panel_nhapXuat.Name = "panel_nhapXuat";
            this.panel_nhapXuat.Size = new System.Drawing.Size(818, 301);
            this.panel_nhapXuat.TabIndex = 10;
            this.panel_nhapXuat.Visible = false;
            // 
            // label_ngayNhap
            // 
            this.label_ngayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ngayNhap.AutoSize = true;
            this.label_ngayNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngayNhap.Location = new System.Drawing.Point(56, 9);
            this.label_ngayNhap.Name = "label_ngayNhap";
            this.label_ngayNhap.Size = new System.Drawing.Size(72, 16);
            this.label_ngayNhap.TabIndex = 0;
            this.label_ngayNhap.Text = "Ngày Nhập";
            // 
            // label_loaiQua
            // 
            this.label_loaiQua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_loaiQua.AutoSize = true;
            this.label_loaiQua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loaiQua.Location = new System.Drawing.Point(57, 68);
            this.label_loaiQua.Name = "label_loaiQua";
            this.label_loaiQua.Size = new System.Drawing.Size(62, 16);
            this.label_loaiQua.TabIndex = 1;
            this.label_loaiQua.Text = "Loại Quả:";
            // 
            // label_soLuong
            // 
            this.label_soLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_soLuong.AutoSize = true;
            this.label_soLuong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soLuong.Location = new System.Drawing.Point(57, 134);
            this.label_soLuong.Name = "label_soLuong";
            this.label_soLuong.Size = new System.Drawing.Size(104, 16);
            this.label_soLuong.TabIndex = 2;
            this.label_soLuong.Text = "Số Lượng (Quả):";
            // 
            // label_ID_coSo
            // 
            this.label_ID_coSo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ID_coSo.AutoSize = true;
            this.label_ID_coSo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID_coSo.Location = new System.Drawing.Point(554, 9);
            this.label_ID_coSo.Name = "label_ID_coSo";
            this.label_ID_coSo.Size = new System.Drawing.Size(62, 16);
            this.label_ID_coSo.TabIndex = 3;
            this.label_ID_coSo.Text = "ID Cơ Sở";
            // 
            // label_gia
            // 
            this.label_gia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_gia.AutoSize = true;
            this.label_gia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gia.Location = new System.Drawing.Point(554, 68);
            this.label_gia.Name = "label_gia";
            this.label_gia.Size = new System.Drawing.Size(107, 16);
            this.label_gia.TabIndex = 4;
            this.label_gia.Text = "Giá Nhập (VNĐ):";
            // 
            // button_tao
            // 
            this.button_tao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_tao.BackColor = System.Drawing.Color.Black;
            this.button_tao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tao.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_tao.Location = new System.Drawing.Point(224, 238);
            this.button_tao.Name = "button_tao";
            this.button_tao.Size = new System.Drawing.Size(151, 42);
            this.button_tao.TabIndex = 5;
            this.button_tao.Text = "Tạo";
            this.button_tao.UseVisualStyleBackColor = false;
            this.button_tao.Click += new System.EventHandler(this.button_tao_Click);
            // 
            // dateTimePicker_nhapXuat
            // 
            this.dateTimePicker_nhapXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_nhapXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_nhapXuat.Location = new System.Drawing.Point(60, 32);
            this.dateTimePicker_nhapXuat.Name = "dateTimePicker_nhapXuat";
            this.dateTimePicker_nhapXuat.Size = new System.Drawing.Size(268, 26);
            this.dateTimePicker_nhapXuat.TabIndex = 6;
            // 
            // comboBox_loaiQua
            // 
            this.comboBox_loaiQua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_loaiQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_loaiQua.FormattingEnabled = true;
            this.comboBox_loaiQua.Location = new System.Drawing.Point(59, 91);
            this.comboBox_loaiQua.Name = "comboBox_loaiQua";
            this.comboBox_loaiQua.Size = new System.Drawing.Size(169, 28);
            this.comboBox_loaiQua.TabIndex = 7;
            // 
            // textBox_ID_coSo
            // 
            this.textBox_ID_coSo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_ID_coSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_coSo.Location = new System.Drawing.Point(557, 34);
            this.textBox_ID_coSo.Name = "textBox_ID_coSo";
            this.textBox_ID_coSo.Size = new System.Drawing.Size(168, 26);
            this.textBox_ID_coSo.TabIndex = 9;
            // 
            // numericUpDown_gia
            // 
            this.numericUpDown_gia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_gia.Location = new System.Drawing.Point(557, 93);
            this.numericUpDown_gia.Name = "numericUpDown_gia";
            this.numericUpDown_gia.Size = new System.Drawing.Size(168, 26);
            this.numericUpDown_gia.TabIndex = 10;
            // 
            // numericUpDown_soLuong
            // 
            this.numericUpDown_soLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_soLuong.Location = new System.Drawing.Point(59, 153);
            this.numericUpDown_soLuong.Name = "numericUpDown_soLuong";
            this.numericUpDown_soLuong.Size = new System.Drawing.Size(169, 26);
            this.numericUpDown_soLuong.TabIndex = 11;
            // 
            // button_huyNhapXuat
            // 
            this.button_huyNhapXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_huyNhapXuat.BackColor = System.Drawing.Color.Black;
            this.button_huyNhapXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huyNhapXuat.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_huyNhapXuat.Location = new System.Drawing.Point(402, 238);
            this.button_huyNhapXuat.Name = "button_huyNhapXuat";
            this.button_huyNhapXuat.Size = new System.Drawing.Size(151, 42);
            this.button_huyNhapXuat.TabIndex = 12;
            this.button_huyNhapXuat.Text = "Hủy";
            this.button_huyNhapXuat.UseVisualStyleBackColor = false;
            this.button_huyNhapXuat.Click += new System.EventHandler(this.button_huyNhapXuat_Click);
            // 
            // Form_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 452);
            this.Controls.Add(this.panel_nhapXuat);
            this.Controls.Add(this.button_themPhieuXuat);
            this.Controls.Add(this.button_themPhieuNhap);
            this.Controls.Add(this.label_danhSach);
            this.Controls.Add(this.dataGridView_fromDataBase);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.button_loiNhuan);
            this.Controls.Add(this.button_tongKetKho);
            this.Controls.Add(this.button_xuatHang);
            this.Controls.Add(this.button_nhapHang);
            this.Name = "Form_QuanLy";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_QuanLy_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fromDataBase)).EndInit();
            this.panel_nhapXuat.ResumeLayout(false);
            this.panel_nhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_nhapHang;
        private System.Windows.Forms.Button button_xuatHang;
        private System.Windows.Forms.Button button_tongKetKho;
        private System.Windows.Forms.Button button_loiNhuan;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.DataGridView dataGridView_fromDataBase;
        private System.Windows.Forms.Label label_danhSach;
        private System.Windows.Forms.Button button_themPhieuNhap;
        private System.Windows.Forms.Button button_themPhieuXuat;
        private System.Windows.Forms.Panel panel_nhapXuat;
        private System.Windows.Forms.TextBox textBox_ID_coSo;
        private System.Windows.Forms.ComboBox comboBox_loaiQua;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nhapXuat;
        private System.Windows.Forms.Button button_tao;
        private System.Windows.Forms.Label label_gia;
        private System.Windows.Forms.Label label_ID_coSo;
        private System.Windows.Forms.Label label_soLuong;
        private System.Windows.Forms.Label label_loaiQua;
        private System.Windows.Forms.Label label_ngayNhap;
        private System.Windows.Forms.NumericUpDown numericUpDown_soLuong;
        private System.Windows.Forms.NumericUpDown numericUpDown_gia;
        private System.Windows.Forms.Button button_huyNhapXuat;
    }
}