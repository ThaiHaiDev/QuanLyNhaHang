using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_QLNH
{
    public partial class MainQuanLy : Form
    {
        public MainQuanLy()
        {
            InitializeComponent();
        }

        private void buttonQuanLyNV_Click(object sender, EventArgs e)
        {
            QuanLyNV_UC qlnhanvien = new QuanLyNV_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(qlnhanvien);
        }

        private void buttonQLBan_Click(object sender, EventArgs e)
        {
            QLBan_UC qlban = new QLBan_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(qlban);
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            ThongKe_UC thongke = new ThongKe_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(thongke);
        }

        private void buttonQLMon_Click(object sender, EventArgs e)
        {
            QLMon_UC qlmon = new QLMon_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(qlmon);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainQuanLy_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonLuongNV_Click(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(DateTime.Now.Hour.ToString());
            int m = Convert.ToInt32(DateTime.Now.Minute.ToString());
            if (h > 22)
            {
                TienLuongNV qlmon = new TienLuongNV();
                panelShow.Controls.Clear();
                panelShow.Controls.Add(qlmon);
            }
            else
            {
                MessageBox.Show("Vui Lòng Quay Lại Lúc 22h05 Để Xem Tổng Kết Lương Cuối Ngày");
            }
        }
    }
}
