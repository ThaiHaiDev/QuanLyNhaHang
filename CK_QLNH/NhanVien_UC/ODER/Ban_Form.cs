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
    public partial class Ban_Form : Form
    {
        public Ban_Form()
        {
            InitializeComponent();
        }
        BANAN banan = new BANAN();
        DataBase mydb = new DataBase();

        public static string idBan;
        public void fillGridB(SqlCommand command)
        {

            dataGridViewBan.ReadOnly = true;
            dataGridViewBan.DataSource = banan.getBanAn(command);
            dataGridViewBan.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridViewBan.Rows.Count; i++)
            {
                if (dataGridViewBan.Rows[i].Cells["Tình Trạng"].ToString().Trim() == "1")
                {
                    dataGridViewBan.Rows[i].Cells["Tình Trạng"].Value = "Trống";
                }
                else if (dataGridViewBan.Rows[i].Cells["Tình Trạng"].ToString().Trim() == "0")
                {
                    dataGridViewBan.Rows[i].Cells["Tình Trạng"].Value = "Đã Được Đặt";
                }
            }
        }
        private void Ban_Form_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand(" SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            SqlCommand commandM = new SqlCommand(" SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn' FROM QLBanAn", mydb.GetConnection);
            SqlDataAdapter adapterM = new SqlDataAdapter(commandM);
            DataTable tableM = new DataTable();
            adapterM.Fill(tableM);
            tableM.Columns.Add("Tình Trạng", typeof(string));
            dataGridViewBan.DataSource = tableM;
            dataGridViewBan.AllowUserToAddRows = false;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToInt32(table.Rows[i]["Tình Trạng"].ToString()) == 1)
                {
                    dataGridViewBan.Rows[i].Cells["Tình Trạng"].Value = "Trống";
                }
                else if (Convert.ToInt32(table.Rows[i]["Tình Trạng"].ToString()) == 0)
                {
                    dataGridViewBan.Rows[i].Cells["Tình Trạng"].Value = "Đã Được Đặt";
                }
            }

        }

        private void dataGridViewBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            idBan = dataGridViewBan.CurrentRow.Cells[0].Value.ToString();
            Oder_Form oder = new Oder_Form();
            oder.Show(this);


        }
        public string IdBanKey = idBan;

        private void Ban_Form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ButtonLocBan_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bàn Trống")
            {
                fillGridB(new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn WHERE tinhtrang = 1"));
            }
            else if (comboBox1.Text == "Bàn Đã Đặt")
            {
                fillGridB(new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn WHERE tinhtrang = 0"));
            }
            else if (comboBox1.Text == "Bàn Gia Đình")
            {
                SqlCommand command = new SqlCommand(" SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn' FROM QLBanAn WHERE soluong >= 4 AND soluong <=8", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewBan.DataSource = table;
                dataGridViewBan.AllowUserToAddRows = false;
                //fillGridB(new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn' FROM QLBanAn WHERE soluong >= 4 AND soluong <=8"));
            }
        }
    }
}
