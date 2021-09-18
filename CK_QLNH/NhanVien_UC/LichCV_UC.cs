using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;
using Point = System.Drawing.Point;

namespace CK_QLNH
{
    public partial class LichCV_UC : UserControl
    {
        public LichCV_UC()
        {
            InitializeComponent();
        }
        DataBase mydb = new DataBase();
        Login_Form login = new Login_Form();
        CaLam calam = new CaLam();
        public static int C1;
        public static int C2;
        private void LichCV_UC_Load(object sender, EventArgs e)
        {
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int mm = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, mm);
            string Thu = dt.DayOfWeek.ToString().Trim();
            int name = login.IDKey;
            // Check xem có lời mời làm hộ nào không.
            SqlCommand commandCa = new SqlCommand(" SELECT Id AS N'Mã NV', Thu2 AS N'Thứ 2', Thu3 AS N'Thứ 3', Thu4 AS N'Thứ 4', Thu5 AS N'Thứ 5', Thu6 AS N'Thứ 6', Thu7 AS N'Thứ 7', CN AS N'Chủ Nhật' FROM ChiaCa WHERE Id = '" + name + "'", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapter.Fill(tableCa);

            if (Thu == "Monday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 2"].ToString()) < 0)
                {
                    if ((MessageBox.Show("Bạn Được Được 1 Lời Đề Nghị Làm Thay Ca. Nên Hôm Nay Bạn Làm Cả 3 Ca. Bạn Có Đồng Ý", "Làm Thay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        calam.updateLamHo2(name, 0);
                    }
                }
            }
            if (Thu == "Tuesday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 3"].ToString()) < 0)
                {
                    if ((MessageBox.Show("Bạn Được Được 1 Lời Đề Nghị Làm Thay Ca. Nên Hôm Nay Bạn Làm Cả 3 Ca. Bạn Có Đồng Ý", "Làm Thay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        calam.updateLamHo3(name, 0);
                    }
                }
            }
            if (Thu == "Wednesday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 4"].ToString()) < 0)
                {
                    if ((MessageBox.Show("Bạn Được Được 1 Lời Đề Nghị Làm Thay Ca. Nên Hôm Nay Bạn Làm Cả 3 Ca. Bạn Có Đồng Ý", "Làm Thay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        calam.updateLamHo4(name, 0);
                    }
                }
            }
            if (Thu == "Thursday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 5"].ToString()) < 0)
                {
                    if ((MessageBox.Show("Bạn Được Được 1 Lời Đề Nghị Làm Thay Ca. Nên Hôm Nay Bạn Làm Cả 3 Ca. Bạn Có Đồng Ý", "Làm Thay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        calam.updateLamHo5(name, 0);
                    }
                }
            }
            if (Thu == "Friday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 6"].ToString()) < 0)
                {
                    if ((MessageBox.Show("Bạn Được Được 1 Lời Đề Nghị Làm Thay Ca. Nên Hôm Nay Bạn Làm Cả 3 Ca. Bạn Có Đồng Ý", "Làm Thay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        calam.updateLamHo6(name, 0);
                    }
                }
            }
            if (Thu == "Saturday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 7"].ToString()) < 0)
                {
                    if ((MessageBox.Show("Bạn Được Được 1 Lời Đề Nghị Làm Thay Ca. Nên Hôm Nay Bạn Làm Cả 3 Ca. Bạn Có Đồng Ý", "Làm Thay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        calam.updateLamHo7(name, 0);
                    }
                }
            }
            if (Thu == "Sunday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Chủ Nhật"].ToString()) < 0)
                {
                    if ((MessageBox.Show("Bạn Được Được 1 Lời Đề Nghị Làm Thay Ca. Nên Hôm Nay Bạn Làm Cả 3 Ca. Bạn Có Đồng Ý", "Làm Thay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        calam.updateLamHoCN(name, 0);
                    }
                }
            }

            SqlCommand commandCaNew = new SqlCommand(" Select Id AS N'Mã NV', Thu2 AS N'Thứ 2', Thu3 AS N'Thứ 3', Thu4 AS N'Thứ 4', Thu5 AS N'Thứ 5', Thu6 AS N'Thứ 6', Thu7 AS N'Thứ 7', CN AS N'Chủ Nhật' FROM ChiaCa WHERE Id = '" + name + "'", mydb.GetConnection);
            SqlDataAdapter adapterNew = new SqlDataAdapter(commandCaNew);
            DataTable tableCaNew = new DataTable();
            adapterNew.Fill(tableCaNew);
            dataGridViewDanhSachNV.DataSource = tableCaNew;
            dataGridViewDanhSachNV.AllowUserToAddRows = false;
            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCaNew.Columns.Count; j++)
                {
                    if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString()) == 3 || Convert.ToInt32(tableCaNew.Rows[i][j].ToString()) == -3)
                    {
                        dataGridViewDanhSachNV.Rows[i].Cells[j].Value = "Ca 1 && Ca 2";
                    }
                    else if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString()) == 2 || Convert.ToInt32(tableCaNew.Rows[i][j].ToString()) == -2)
                    {
                        dataGridViewDanhSachNV.Rows[i].Cells[j].Value = "Ca 1 && Ca 3";
                    }
                    else if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString()) == 1 || Convert.ToInt32(tableCaNew.Rows[i][j].ToString()) == -1)
                    {
                        dataGridViewDanhSachNV.Rows[i].Cells[j].Value = "Ca 2 && Ca 3";
                    }
                    else if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString()) == 0)
                    {
                        dataGridViewDanhSachNV.Rows[i].Cells[j].Value = "Ca 1 && Ca 2 && Ca 3";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxCaM.Enabled = true;
            comboBoxCaN.Enabled = true;
            int ID = login.IDKey;

            SqlCommand commandCa = new SqlCommand(" Select Id AS N'Mã NV', Thu2 AS N'Thứ 2', Thu3 AS N'Thứ 3', Thu4 AS N'Thứ 4', Thu5 AS N'Thứ 5', Thu6 AS N'Thứ 6', Thu7 AS N'Thứ 7', CN AS N'Chủ Nhật' FROM ChiaCa WHERE Id = '" + ID + "'", mydb.GetConnection);
            SqlDataAdapter adapterCa = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapterCa.Fill(tableCa);


            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "Monday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 2"]) == 1)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu2 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 2);
                    C1 = 2;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu2 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 2"]) == 2)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu2 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu2 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 2"]) == 3)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu2 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu2 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 2);
                    C2 = 2;
                }
            }
            if (thu == "Tuesday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 3"]) == 1)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu3 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 2);
                    C1 = 2;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu3 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 3"]) == 2)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu3 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu3 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 3"]) == 3)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu3 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu3 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 2);
                    C2 = 2;
                }
            }
            if (thu == "Wednesday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 4"]) == 1)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu4 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 2);
                    C1 = 2;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu4 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 4"]) == 2)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu4 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu4 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 4"]) == 3)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu4 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu4 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 2);
                    C2 = 2;
                }
            }
            if (thu == "Thursday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 5"]) == 1)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu5 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 2);
                    C1 = 2;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu5 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 5"]) == 2)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu5 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu5 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 5"]) == 3)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu5 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu5 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 2);
                    C2 = 2;
                }
            }
            if (thu == "Friday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 6"]) == 1)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu6 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 2);
                    C1 = 2;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu6 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 6"]) == 2)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu6 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu6 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 6"]) == 3)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu6 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu6 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 2);
                    C2 = 2;
                }
            }
            if (thu == "Saturday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Thứ 7"]) == 1)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu7 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 2);
                    C1 = 2;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu7 = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 7"]) == 2)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu7 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu7 = 3  AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Thứ 7"]) == 3)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu7 = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE Thu7 = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 2);
                    C2 = 2;
                }
            }
            if (thu == "Sunday")
            {
                if (Convert.ToInt32(tableCa.Rows[0]["Chủ Nhật"]) == 1)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE CN = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 2);
                    C1 = 2;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE CN = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Chủ Nhật"]) == 2)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE CN = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE CN = 3 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0]["Chủ Nhật"]) == 3)
                {
                    SqlCommand command = new SqlCommand(" SELECT Id FROM ChiaCa WHERE CN = 1 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ShowM(table, 1);
                    C1 = 1;
                    SqlCommand command1 = new SqlCommand(" SELECT Id FROM ChiaCa WHERE CN = 2 AND Id <>" + ID, mydb.GetConnection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    ShowN(table1, 2);
                    C2 = 2;
                }
            }

        }
        public void ShowM(DataTable m, int c1)
        {
            labelCaM.Text = "Những Nhân Viên Trống Ca " + c1;
            comboBoxCaM.DataSource = m;
            comboBoxCaM.DisplayMember = "Id";
            comboBoxCaM.ValueMember = "Id";
        }
        public void ShowN(DataTable n, int c2)
        {
            labelCaN.Text = "Những Nhân Viên Trống Ca " + c2;
            comboBoxCaN.DataSource = n;
            comboBoxCaN.DisplayMember = "Id";
            comboBoxCaN.ValueMember = "Id";
        }

        private void buttonLam_Click(object sender, EventArgs e)
        {
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "Monday")
            {
                calam.updateLamHo2(Convert.ToInt32(comboBoxCaM.Text.Trim()), -1 * C1);
                calam.updateLamHo2(Convert.ToInt32(comboBoxCaN.Text.Trim()), -1 * C2);
            }
            if (thu == "Tuesday")
            {
                calam.updateLamHo3(Convert.ToInt32(comboBoxCaM.Text.Trim()), -1 * C1);
                calam.updateLamHo3(Convert.ToInt32(comboBoxCaN.Text.Trim()), -1 * C2);
            }
            if (thu == "Wednesday")
            {
                calam.updateLamHo4(Convert.ToInt32(comboBoxCaM.Text.Trim()), -1 * C1);
                calam.updateLamHo4(Convert.ToInt32(comboBoxCaN.Text.Trim()), -1 * C2);
            }
            if (thu == "Thursday")
            {
                calam.updateLamHo5(Convert.ToInt32(comboBoxCaM.Text.Trim()), -1 * C1);
                calam.updateLamHo5(Convert.ToInt32(comboBoxCaN.Text.Trim()), -1 * C2);
            }
            if (thu == "Friday")
            {
                calam.updateLamHo6(Convert.ToInt32(comboBoxCaM.Text.Trim()), -1 * C1);
                calam.updateLamHo6(Convert.ToInt32(comboBoxCaN.Text.Trim()), -1 * C2);
            }
            if (thu == "Saturday")
            {
                calam.updateLamHo7(Convert.ToInt32(comboBoxCaM.Text.Trim()), -1 * C1);
                calam.updateLamHo7(Convert.ToInt32(comboBoxCaN.Text.Trim()), -1 * C2);
            }
            if (thu == "Sunday")
            {
                calam.updateLamHoCN(Convert.ToInt32(comboBoxCaM.Text.Trim()), -1 * C1);
                calam.updateLamHoCN(Convert.ToInt32(comboBoxCaN.Text.Trim()), -1 * C2);
            }
            MessageBox.Show("Đã Gửi Làm Mời");
        }

        private void buttonSaveWord_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dataGridViewDanhSachNV.Columns.Count;
            object missing = System.Reflection.Missing.Value;
            Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
            string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
                + DateTime.Today.Year.ToString("0000");
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdRed;
                headerRange.Font.Size = 16;
                headerRange.Text = "LỊCH LÀM VIỆC\n" + time;



                Range footersRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footersRange.Fields.Add(footersRange, WdFieldType.wdFieldPage);
                footersRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                footersRange.Font.ColorIndex = WdColorIndex.wdBlack;   // Màu
                footersRange.Font.Bold = 2;        // Độ Đậm Chữ
                footersRange.Font.Size = 16;
                footersRange.Text = "TP.HCM, " + time;


                section.Borders.Enable = 1;
                section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                section.Borders.OutsideColor = WdColor.wdColorBlack;

            }

            // Tạo bảng danh sách sinh viên
            Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewDanhSachNV.Rows.Count + 1, dataGridViewDanhSachNV.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewDanhSachNV.Columns[c].HeaderText;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dataGridViewDanhSachNV.Rows[i - 2].Cells[j - 1].Value.ToString();
                    tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            object filename = @"D:\LichLamViec.docx";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Print Document";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            pDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = pDoc;
                printPreviewDialog1.ShowDialog();
                pDoc.Print();
            }
            else
            {
                MessageBox.Show("Ðã huy in");
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string str = "";
            int row = dataGridViewDanhSachNV.Rows.Count;
            int cell = dataGridViewDanhSachNV.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    if (dataGridViewDanhSachNV.Rows[i].Cells[j].Value == null)
                    {
                        dataGridViewDanhSachNV.Rows[i].Cells[j].Value = "null";
                    }
                    str += dataGridViewDanhSachNV.Rows[i].Cells[j].Value.ToString().Trim() + " , ";
                }
                str += "\n";
            }

            e.Graphics.DrawString(str, new Font("Arial", 30), Brushes.Black, new Point(10, 10));
        }
    }
}
