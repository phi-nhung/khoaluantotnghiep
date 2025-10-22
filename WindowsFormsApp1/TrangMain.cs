using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TrangMain : Form
    {
        public TrangMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SkyBlue; // Màu xanh ngọc sáng
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.LightSkyBlue;
            btn.FlatAppearance.BorderSize = 2;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnTrangChu)
            {
                btn.BackColor = Color.FromArgb(255, 255, 255); // Màu xanh đặc biệt cho trang chủ
            }
            else
            {
                btn.BackColor = Color.FromArgb(255, 255, 255); // Màu xám đen cho các nút khác
            }
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);
            btn.FlatAppearance.BorderSize = 2;
        }
    }
}
