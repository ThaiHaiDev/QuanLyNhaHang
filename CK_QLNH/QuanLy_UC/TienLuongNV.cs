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
    public partial class TienLuongNV : UserControl
    {
        public TienLuongNV()
        {
            InitializeComponent();
        }
        Login_Form login = new Login_Form();
        DataBase mydb = new DataBase();
        private void TienLuongNV_Load(object sender, EventArgs e)
        {
            int ID = login.IDKey;
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "Monday")
            {
                SqlCommand command = new SqlCommand(" SELECT Id AS N'Mã Nhân Viên',Luong2 AS N'Luong Today' FROM LuongNV", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDanhSachNV.DataSource = table;
                dataGridViewDanhSachNV.AllowUserToAddRows = false;
            }
            if (thu == "Tuesday")
            {
                SqlCommand command = new SqlCommand(" SELECT Id AS N'Mã Nhân Viên',Luong3 AS N'Luong Today' FROM LuongNV", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDanhSachNV.DataSource = table;
                dataGridViewDanhSachNV.AllowUserToAddRows = false;
            }
            if (thu == "Wednesday")
            {
                SqlCommand command = new SqlCommand(" SELECT Id AS N'Mã Nhân Viên',Luong4 AS N'Luong Today' FROM LuongNV", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDanhSachNV.DataSource = table;
                dataGridViewDanhSachNV.AllowUserToAddRows = false;
            }
            if (thu == "Thursday")
            {
                SqlCommand command = new SqlCommand(" SELECT Id AS N'Mã Nhân Viên',Luong5 AS N'Luong Today' FROM LuongNV", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDanhSachNV.DataSource = table;
                dataGridViewDanhSachNV.AllowUserToAddRows = false;
            }
            if (thu == "Friday")
            {
                SqlCommand command = new SqlCommand(" SELECT Id AS N'Mã Nhân Viên',Luong6 AS N'Luong Today' FROM LuongNV", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDanhSachNV.DataSource = table;
                dataGridViewDanhSachNV.AllowUserToAddRows = false;
            }
            if (thu == "Saturday")
            {
                SqlCommand command = new SqlCommand(" SELECT Id AS N'Mã Nhân Viên',Luong7 AS N'Luong Today' FROM LuongNV", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDanhSachNV.DataSource = table;
                dataGridViewDanhSachNV.AllowUserToAddRows = false;
            }
            if (thu == "Sunday")
            {
                SqlCommand command = new SqlCommand(" SELECT Id AS N'Mã Nhân Viên',LuongCN AS N'Luong Today' FROM LuongNV", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDanhSachNV.DataSource = table;
                dataGridViewDanhSachNV.AllowUserToAddRows = false;
            }
        }
    }
}
