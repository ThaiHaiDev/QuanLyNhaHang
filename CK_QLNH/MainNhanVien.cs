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
    public partial class MainNhanVien : Form
    {
        public MainNhanVien()
        {
            InitializeComponent();
        }
        Login_Form login = new Login_Form();
        DataBase mydb = new DataBase();
        private void buttonTTNV_Click(object sender, EventArgs e)
        {
            ThongTinNV_UC ttnv = new ThongTinNV_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(ttnv);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            CheckInOut_UC check = new CheckInOut_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(check);
        }

        private void buttonLichCV_Click(object sender, EventArgs e)
        {
            LichCV_UC lich = new LichCV_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(lich);
        }

        private void buttonOder_Click(object sender, EventArgs e)
        {
            QLOder_UC oder = new QLOder_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(oder);
        }

        private void buttonLuong_Click(object sender, EventArgs e)
        {
            LuongNV_UC luong = new LuongNV_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(luong);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainNhanVien_Load(object sender, EventArgs e)
        {
            labelIDNV.BackColor = Color.Transparent;
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            SqlCommand command = new SqlCommand(" SELECT Id,TenNV,HoNV FROM ListNV_ WHERE Id = '" + login.IDKey + "' ", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            labelIDNV.Text = "Xin Chào Nhân Viên: " + table.Rows[0][2].ToString().Trim() + " " + table.Rows[0][1].ToString().Trim();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
