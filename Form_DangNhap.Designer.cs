namespace AppQL
{
    partial class Form_dangNhap
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
            this.label_tenDangNhap = new System.Windows.Forms.Label();
            this.textBox_tenDangNhap = new System.Windows.Forms.TextBox();
            this.label_matKhau = new System.Windows.Forms.Label();
            this.textBox_matKhau = new System.Windows.Forms.TextBox();
            this.button_dangNhap = new System.Windows.Forms.Button();
            this.button_dangKy = new System.Windows.Forms.Button();
            this.label_report = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_tenDangNhap
            // 
            this.label_tenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_tenDangNhap.AutoSize = true;
            this.label_tenDangNhap.Location = new System.Drawing.Point(148, 76);
            this.label_tenDangNhap.Name = "label_tenDangNhap";
            this.label_tenDangNhap.Size = new System.Drawing.Size(81, 13);
            this.label_tenDangNhap.TabIndex = 0;
            this.label_tenDangNhap.Text = "Tên đăng nhập";
            // 
            // textBox_tenDangNhap
            // 
            this.textBox_tenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_tenDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenDangNhap.Location = new System.Drawing.Point(151, 92);
            this.textBox_tenDangNhap.Name = "textBox_tenDangNhap";
            this.textBox_tenDangNhap.Size = new System.Drawing.Size(315, 29);
            this.textBox_tenDangNhap.TabIndex = 1;
            // 
            // label_matKhau
            // 
            this.label_matKhau.AllowDrop = true;
            this.label_matKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_matKhau.AutoEllipsis = true;
            this.label_matKhau.AutoSize = true;
            this.label_matKhau.Location = new System.Drawing.Point(148, 132);
            this.label_matKhau.Name = "label_matKhau";
            this.label_matKhau.Size = new System.Drawing.Size(52, 13);
            this.label_matKhau.TabIndex = 2;
            this.label_matKhau.Text = "Mật khẩu";
            this.label_matKhau.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_matKhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matKhau.Location = new System.Drawing.Point(151, 148);
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.Size = new System.Drawing.Size(315, 29);
            this.textBox_matKhau.TabIndex = 3;
            this.textBox_matKhau.UseSystemPasswordChar = true;
            this.textBox_matKhau.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_dangNhap
            // 
            this.button_dangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_dangNhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_dangNhap.Location = new System.Drawing.Point(151, 211);
            this.button_dangNhap.Name = "button_dangNhap";
            this.button_dangNhap.Size = new System.Drawing.Size(123, 46);
            this.button_dangNhap.TabIndex = 4;
            this.button_dangNhap.Text = "Đăng nhập";
            this.button_dangNhap.UseVisualStyleBackColor = false;
            this.button_dangNhap.Click += new System.EventHandler(this.button_dangNhap_Click);
            // 
            // button_dangKy
            // 
            this.button_dangKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_dangKy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_dangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_dangKy.Location = new System.Drawing.Point(343, 211);
            this.button_dangKy.Name = "button_dangKy";
            this.button_dangKy.Size = new System.Drawing.Size(123, 46);
            this.button_dangKy.TabIndex = 5;
            this.button_dangKy.Text = "Đăng ký";
            this.button_dangKy.UseVisualStyleBackColor = false;
            // 
            // label_report
            // 
            this.label_report.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_report.AutoSize = true;
            this.label_report.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_report.ForeColor = System.Drawing.Color.Red;
            this.label_report.Location = new System.Drawing.Point(151, 184);
            this.label_report.Name = "label_report";
            this.label_report.Size = new System.Drawing.Size(0, 17);
            this.label_report.TabIndex = 6;
            this.label_report.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form_dangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(612, 326);
            this.Controls.Add(this.label_report);
            this.Controls.Add(this.button_dangKy);
            this.Controls.Add(this.button_dangNhap);
            this.Controls.Add(this.textBox_matKhau);
            this.Controls.Add(this.label_matKhau);
            this.Controls.Add(this.textBox_tenDangNhap);
            this.Controls.Add(this.label_tenDangNhap);
            this.Name = "Form_dangNhap";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_dangNhap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tenDangNhap;
        private System.Windows.Forms.TextBox textBox_tenDangNhap;
        private System.Windows.Forms.Label label_matKhau;
        private System.Windows.Forms.TextBox textBox_matKhau;
        private System.Windows.Forms.Button button_dangNhap;
        private System.Windows.Forms.Button button_dangKy;
        private System.Windows.Forms.Label label_report;
    }
}

