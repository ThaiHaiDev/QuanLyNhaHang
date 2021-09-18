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
    public partial class ChiaCaForm : Form
    {
        public ChiaCaForm()
        {
            InitializeComponent();
        }
        DataBase mydb = new DataBase();
        NhanVien nhanvien = new NhanVien();
        public DataTable showData(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void buttonChiaCa_Click(object sender, EventArgs e)
        {
            SqlCommand commandCa = new SqlCommand(" SELECT NhanVien.Id, Thu2, Thu3, Thu4, Thu5, Thu6, Thu7, CN FROM ChiaCa RIGHT JOIN NhanVien ON ChiaCa.Id = NhanVien.Id ", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapter.Fill(tableCa);

            int n;
            Random rd = new Random();
            n = rd.Next(1, 4);
            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCa.Columns.Count; j++)
                {
                    tableCa.Rows[i][j] = n;
                    n++;
                    if (n == 4)
                    {
                        n = 1;
                    }
                }

                nhanvien.updateCaLam(Convert.ToInt32(tableCa.Rows[i]["Id"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu2"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu3"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu4"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu5"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu6"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu7"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["CN"].ToString()));
            }

            dataGridViewChiaCaNV.DataSource = tableCa;
            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCa.Columns.Count; j++)
                {
                    if (Convert.ToInt32(tableCa.Rows[i][j].ToString()) == 3)
                    {
                        dataGridViewChiaCaNV.Rows[i].Cells[j].Value = "Ca1, Ca2";

                    }
                    else if (Convert.ToInt32(tableCa.Rows[i][j].ToString()) == 2)
                    {
                        dataGridViewChiaCaNV.Rows[i].Cells[j].Value = "Ca1, Ca3";
                    }
                    else
                    {
                        dataGridViewChiaCaNV.Rows[i].Cells[j].Value = "Ca2, Ca3";
                    }
                }
            }
            dataGridViewChiaCaNV.AllowUserToAddRows = false;
            MessageBox.Show("CHIA CA THÀNH CÔNG CHO NHÂN VIÊN!!!");
        }
    }
}
