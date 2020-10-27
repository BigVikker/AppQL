using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQL
{
    public partial class Form_dangNhap : System.Windows.Forms.Form
    {
        public Form_dangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button_dangNhap_Click(object sender, EventArgs e)
        {
            /// if true
            if (textBox_tenDangNhap.Text == "" && textBox_matKhau.Text == "")
            {
                Form_QuanLy form_QuanLy = new Form_QuanLy(this);
                form_QuanLy.Show();
                this.Hide();
                textBox_tenDangNhap.Text = "";
                textBox_matKhau.Text = "";
                label_report.Text = "";
            }
            else
            {
                label_report.Text = "Sai mật khẩu hoặc tên đăng nhập !";
            }
            return;
            
        }
        private void Form_dangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
