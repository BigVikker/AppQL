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
    public partial class Form_QuanLy : System.Windows.Forms.Form
    {
        private Form_dangNhap main_form;

        public Form_QuanLy(Form_dangNhap main_form)
        {
            InitializeComponent();
            this.main_form = main_form;
        }
        public Form_QuanLy()
        {
            InitializeComponent();
        }
        private bool xClicked = true;

        

        private void Form_QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClicked)
            {
                // user click the X
                Application.Exit();
            }
            else
            {
                // user click the close button
                this.main_form.Show();
            }
        }
        private void button_logOut_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();
            return;
        }
        private void default_backgroup_color()
        {
            button_nhapHang.BackColor = Color.Gray;
            button_tongKetKho.BackColor = Color.Gray;
            button_xuatHang.BackColor = Color.Gray;
            button_loiNhuan.BackColor = Color.Gray;
            button_themPhieuNhap.Visible = false;
            button_themPhieuXuat.Visible = false;
        }
        private void button_nhapHang_Click(object sender, EventArgs e)
        {

            this.default_backgroup_color();
            button_themPhieuNhap.Visible = true;
            label_danhSach.Text = "Danh sách nhập hàng:";
            button_nhapHang.BackColor = Color.Orange;
            return;
        }

        private void button_xuatHang_Click(object sender, EventArgs e)
        {
            this.default_backgroup_color();
            button_themPhieuXuat.Visible = true;
            label_danhSach.Text = "Danh sách xuất hàng:";
            button_xuatHang.BackColor = Color.Orange;
            return;
        }

        private void button_tongKetKho_Click(object sender, EventArgs e)
        {
            this.default_backgroup_color();
            label_danhSach.Text = "Danh sách thống kê:";
            button_tongKetKho.BackColor = Color.Orange;
            return;
        }

        private void button_loiNhuan_Click(object sender, EventArgs e)
        {
            this.default_backgroup_color();
            label_danhSach.Text = "Danh sách lợi nhuận:";
            button_loiNhuan.BackColor = Color.Orange;
            return;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_fromDataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void disableAllbtn()
        {
            button_loiNhuan.Enabled = false;
            button_nhapHang.Enabled = false;
            button_xuatHang.Enabled = false;
            button_tongKetKho.Enabled = false;

        }
        private void enableAllbtn()
        {
            button_loiNhuan.Enabled = true;
            button_nhapHang.Enabled = true;
            button_xuatHang.Enabled = true;
            button_tongKetKho.Enabled = true;

        }

        private void button_themPhieuNhap_Click(object sender, EventArgs e)
        {
            disableAllbtn();
            label_danhSach.Text = "Tạo Phiếu Nhập";
            label_ngayNhap.Text = "Ngày Nhập";
            label_gia.Text = "Giá Nhập";
            dataGridView_fromDataBase.Hide();

            /// thêm vào trong combo box loại trái cai từ data base
            /// foreach a in loaiQua{
            comboBox_loaiQua.Items.Add("Cam");
            //}

            panel_nhapXuat.Show();
        }
        private void button_themPhieuXuat_Click(object sender, EventArgs e)
        {
            disableAllbtn();
            label_danhSach.Text = "Tạo Phiếu Xuất";
            label_ngayNhap.Text = "Ngày Xuất";
            label_gia.Text = "Giá Xuất";
            dataGridView_fromDataBase.Hide();

            /// thêm vào trong combo box loại trái cai từ data base
            /// foreach a in loaiQua{
            comboBox_loaiQua.Items.Add("Cam");
            //}
            panel_nhapXuat.Show();
        }

        private void panelReturnstats()
        {
            dateTimePicker_nhapXuat.Value = DateTime.Today;
            comboBox_loaiQua.Items.Clear();
            numericUpDown_soLuong.Value = 0;
            numericUpDown_gia.Value = 0;
            textBox_ID_coSo.Text = "";

        }
        private void button_tao_Click(object sender, EventArgs e)
        {
            if (button_nhapHang.BackColor == Color.Orange)
            {
                //La tao phieu nhap

                MessageBox.Show("Thành Công Tạo Phiếu Nhập !", "Thành Công !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label_danhSach.Text = "Danh sách nhập hàng";
            }
            else
            {
                // la tao phieu xuat
                MessageBox.Show("Thành Công Tạo Phiếu Xuất !", "Thành Công !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label_danhSach.Text = "Danh sách xuất hàng";
            }
            panelReturnstats();
            panel_nhapXuat.Hide();
            // update lai dataGripView de hien
            dataGridView_fromDataBase.Show();
            enableAllbtn();
            return;
        }

        private void button_huyNhapXuat_Click(object sender, EventArgs e)
        {
            if (button_nhapHang.BackColor == Color.Orange)
            {
                label_danhSach.Text = "Danh sách nhập hàng";
            }
            else
            {
                label_danhSach.Text = "Danh sách xuất hàng";
            }
            panelReturnstats();
            panel_nhapXuat.Hide();
            dataGridView_fromDataBase.Show();
            enableAllbtn();
            return;
        }
    }
}
