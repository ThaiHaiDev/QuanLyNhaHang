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
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;

namespace CK_QLNH
{
    public partial class ThongKe_UC : UserControl
    {
        public ThongKe_UC()
        {
            InitializeComponent();
        }
        DataBase mydb = new DataBase();
        public static int k;
        MONAN monan = new MONAN();
        private void buttonDoanhThu_Click(object sender, EventArgs e)
        {


            if (radioButton1Ngay.Checked == true)
            {
                int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
                int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
                int kk = Convert.ToInt32(DateTime.Now.Day.ToString());

                if (radioButtonDTMon.Checked == true)
                {
                    SqlCommand command = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', tenmonhd as N'Tên Món', soluong as N'Số Lượng Món', giathanh as N'Giá Tổng', thoigian as N'Thời Gian' FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + yy + "' AND    DATEPART(mm, thoigian) = '" + dd + "' AND    DATEPART(dd, thoigian) = '" + kk + "')", mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewDTMon.DataSource = table;
                    dataGridViewDTMon.AllowUserToAddRows = false;
                }
                if (radioButtonDTBan.Checked == true)
                {
                    SqlCommand commandban = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', sotien as N'Số Tiền', date as N'Thời Gian' FROM DoanhThuBan WHERE(DATEPART(yy, date) = '" + yy + "' AND    DATEPART(mm, date) = '" + dd + "' AND    DATEPART(dd, date) = '" + kk + "')", mydb.GetConnection);
                    SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
                    DataTable tableban = new DataTable();
                    adapterban.Fill(tableban);
                    dataGridViewDTMon.DataSource = tableban;
                    dataGridViewDTMon.AllowUserToAddRows = false;
                }
                SqlCommand command1 = new SqlCommand("SELECT sum(sotien) as N'SL'  FROM DoanhThuBan WHERE(DATEPART(yy, date) = '" + yy + "' AND    DATEPART(mm, date) = '" + dd + "' AND    DATEPART(dd, date) = '" + kk + "')", mydb.GetConnection);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);


                SqlCommand command11 = new SqlCommand("SELECT sum(giathanh) as N'SL'  FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + yy + "' AND    DATEPART(mm, thoigian) = '" + dd + "' AND    DATEPART(dd, thoigian) = '" + kk + "')", mydb.GetConnection);
                SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
                DataTable table11 = new DataTable();
                adapter11.Fill(table11);

                labelDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (Convert.ToInt32(table1.Rows[0][0].ToString()) + Convert.ToInt32(table11.Rows[0][0].ToString()));
            }
            if (radioButton1Thang.Checked == true)
            {
                int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
                int month = Convert.ToInt32(comboBoxMonth.Text);

                if (radioButtonDTMon.Checked == true)
                {
                    SqlCommand command = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', tenmonhd as N'Tên Món', soluong as N'Số Lượng Món', giathanh as N'Giá Tổng', thoigian as N'Thời Gian' FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + yy + "' AND    DATEPART(mm, thoigian) = '" + month + "' )", mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewDTMon.DataSource = table;
                    dataGridViewDTMon.AllowUserToAddRows = false;
                }

                if (radioButtonDTBan.Checked == true)
                {
                    SqlCommand commandban = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', sotien as N'Số Tiền', date as N'Thời Gian' FROM DoanhThuBan WHERE(DATEPART(yy, date) = '" + yy + "' AND    DATEPART(mm, date) = '" + month + "' )", mydb.GetConnection);
                    SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
                    DataTable tableban = new DataTable();
                    adapterban.Fill(tableban);
                    dataGridViewDTMon.DataSource = tableban;
                    dataGridViewDTMon.AllowUserToAddRows = false;
                }
                SqlCommand command1 = new SqlCommand("SELECT sum(sotien) as N'SL'  FROM DoanhThuBan  WHERE(DATEPART(yy, date) = '" + yy + "' AND    DATEPART(mm, date) = '" + month + "' )", mydb.GetConnection);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);


                SqlCommand command11 = new SqlCommand("SELECT sum(giathanh) as N'SL'  FROM DoanhThu  WHERE(DATEPART(yy, thoigian) = '" + yy + "' AND    DATEPART(mm, thoigian) = '" + month + "' )", mydb.GetConnection);
                SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
                DataTable table11 = new DataTable();
                adapter11.Fill(table11);
                int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
                if (month == dd)
                {
                    labelDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (Convert.ToInt32(table1.Rows[0][0].ToString()) + Convert.ToInt32(table11.Rows[0][0].ToString()));
                }
                else
                {
                    labelDoanhThu.Text = "KHÔNG CÓ DOANH THU THÁNG NÀY";
                }

            }
            if (radioButtonNam.Checked == true)
            {

                int year = Convert.ToInt32(numericUpDownYear.Value);

                if (radioButtonDTMon.Checked == true)
                {
                    SqlCommand command = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', tenmonhd as N'Tên Món', soluong as N'Số Lượng Món', giathanh as N'Giá Tổng', thoigian as N'Thời Gian' FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + year + "')", mydb.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewDTMon.DataSource = table;
                    dataGridViewDTMon.AllowUserToAddRows = false;
                }

                if (radioButtonDTBan.Checked == true)
                {
                    SqlCommand commandban = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', sotien as N'Số Tiền', date as N'Thời Gian' FROM DoanhThuBan WHERE(DATEPART(yy, date) = '" + year + "')", mydb.GetConnection);
                    SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
                    DataTable tableban = new DataTable();
                    adapterban.Fill(tableban);
                    dataGridViewDTMon.DataSource = tableban;
                    dataGridViewDTMon.AllowUserToAddRows = false;
                }
                SqlCommand command1 = new SqlCommand("SELECT sum(sotien) as N'SL'  FROM DoanhThuBan WHERE(DATEPART(yy, date) = '" + year + "')", mydb.GetConnection);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);


                SqlCommand command11 = new SqlCommand("SELECT sum(giathanh) as N'SL'  FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + year + "')", mydb.GetConnection);
                SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
                DataTable table11 = new DataTable();
                adapter11.Fill(table11);

                int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
                if (year == yy)
                {
                    labelDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (Convert.ToInt32(table1.Rows[0][0].ToString()) + Convert.ToInt32(table11.Rows[0][0].ToString()));
                }
                else
                {
                    labelDoanhThu.Text = "KHÔNG CÓ DOANH THU NĂM NÀY";
                }


            }
        }

        private void buttonMonTop_Click(object sender, EventArgs e)
        {

            if (radioButton1Ngay.Checked == true)
            {
                int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
                int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
                int kk = Convert.ToInt32(DateTime.Now.Day.ToString());

                SqlCommand command = new SqlCommand(" SELECT sum(soluong) as N'Số Lượng', tenmonhd as N'Tên Món Ăn' FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + yy + "' AND    DATEPART(mm, thoigian) = '" + dd + "' AND    DATEPART(dd, thoigian) = '" + kk + "') GROUP BY tenmonhd ORDER BY N'Số Lượng' DESC", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDTMon.DataSource = table;

                dataGridViewDTMon.DataSource = table;
                dataGridViewDTMon.AllowUserToAddRows = false;
                try
                {
                    int len = this.dataGridViewDTMon.Rows.Count;
                    for (int i = 0; i < len; i++)
                    {

                        string s = dataGridViewDTMon.Rows[i].Cells[1].Value.ToString();
                        string k = dataGridViewDTMon.Rows[i].Cells[0].Value.ToString();
                        double kq = Convert.ToDouble(k);
                        BieuDoCot.Series["MonAn"].Points.AddXY(s, k);
                    }
                }
                catch (NullReferenceException ee)
                {
                    ee.InnerException.ToString();
                }


            }
            if (radioButton1Thang.Checked == true)
            {
                int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
                int month = Convert.ToInt32(comboBoxMonth.Text);


                SqlCommand command = new SqlCommand(" SELECT sum(soluong) as N'Số Lượng', tenmonhd as N'Tên Món Ăn' FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + yy + "' AND    DATEPART(mm, thoigian) = '" + month + "' ) GROUP BY tenmonhd ORDER BY N'Số Lượng' DESC", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDTMon.DataSource = table;
                dataGridViewDTMon.AllowUserToAddRows = false;

                dataGridViewDTMon.DataSource = table;
                dataGridViewDTMon.AllowUserToAddRows = false;
                try
                {
                    int len = this.dataGridViewDTMon.Rows.Count;
                    for (int i = 0; i < len; i++)
                    {

                        string s = dataGridViewDTMon.Rows[i].Cells[1].Value.ToString();
                        string k = dataGridViewDTMon.Rows[i].Cells[0].Value.ToString();
                        double kq = Convert.ToDouble(k);
                        BieuDoCot.Series["MonAn"].Points.AddXY(s, k);
                    }
                }
                catch (NullReferenceException ee)
                {
                    ee.InnerException.ToString();
                }

            }
            if (radioButtonNam.Checked == true)
            {
                int year = Convert.ToInt32(numericUpDownYear.Value);



                SqlCommand command = new SqlCommand(" SELECT sum(soluong) as N'Số Lượng', tenmonhd as N'Tên Món Ăn' FROM DoanhThu WHERE(DATEPART(yy, thoigian) = '" + year + "') GROUP BY tenmonhd ORDER BY N'Số Lượng' DESC", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDTMon.DataSource = table;
                dataGridViewDTMon.AllowUserToAddRows = false;

                dataGridViewDTMon.DataSource = table;
                dataGridViewDTMon.AllowUserToAddRows = false;
                try
                {
                    int len = this.dataGridViewDTMon.Rows.Count;
                    for (int i = 0; i < len; i++)
                    {

                        string s = dataGridViewDTMon.Rows[i].Cells[1].Value.ToString();
                        string k = dataGridViewDTMon.Rows[i].Cells[0].Value.ToString();
                        double kq = Convert.ToDouble(k);
                        BieuDoCot.Series["MonAn"].Points.AddXY(s, k);
                    }
                }
                catch (NullReferenceException ee)
                {
                    ee.InnerException.ToString();
                }

            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dataGridViewDTMon.Columns.Count;
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
                headerRange.Text = "THỐNG KÊ NHÀ HÀNG\n" + time;



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
            Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewDTMon.Rows.Count + 1, dataGridViewDTMon.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewDTMon.Columns[c].HeaderText;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dataGridViewDTMon.Rows[i - 2].Cells[j - 1].Value.ToString();
                    tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            object filename = @"D:\ThongKeNhaHang.docx";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Đã Lưu Doanh Thu", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
