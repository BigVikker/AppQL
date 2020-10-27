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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fromDataBase)).BeginInit();
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
            this.dataGridView_fromDataBase.Size = new System.Drawing.Size(817, 189);
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
            // 
            // Form_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 340);
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
    }
}