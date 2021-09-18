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
    public partial class LuongNV_UC : UserControl
    {
        public LuongNV_UC()
        {
            InitializeComponent();
        }
        DataBase myDb = new DataBase();
        Login_Form login = new Login_Form();
        IDLamViec idl = new IDLamViec();
        private void LuongNV_UC_Load(object sender, EventArgs e)
        {
            UpdateLuong();
            if (TotalTimeLamViec() >= 7)
            {
                MessageBox.Show("Hôm Nay Bạn Đã Làm Đủ " + Convert.ToDouble(TotalTimeLamViec().ToString()) + " Tiếng Nên Sẽ Được Tính Lương!");
                labelLuong.Text = "Lương Hôm Nay Của Bạn Là: " + TinhTien();
                //MessageBox.Show("Lương Hôm Nay Của Bạn Là: " + TinhTien());
            }
            else
            {
                MessageBox.Show("Hôm Nay Bạn Chưa Làm Đủ Thời Gian Yêu Cầu. Chỉ " + Math.Abs(Convert.ToDouble(TotalTimeLamViec().ToString())) + " Giờ. Như Vậy Bạn Thiếu " + (8 - Math.Abs(Convert.ToDouble(TotalTimeLamViec().ToString()))) + " Giờ Nên Sẽ Tính Lương Nhưng Trừ 100.000 Mỗi Giờ Thiếu!");
                labelLuong.Text = "Lương Hôm Nay Của Bạn Là: " + TinhTien();
            }
            int name = login.IDKey;
            SqlCommand command = new SqlCommand(" SELECT * FROM LuongNV WHERE Id = '" + name + "'", myDb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewDanhSachNV.DataSource = table;
            dataGridViewDanhSachNV.AllowUserToAddRows = false;
        }
        // Tính Total Time Làm việc Trong Ngày
        public double TotalTimeLamViec()
        {
            int name = login.IDKey;
            SqlCommand command = new SqlCommand(" SELECT * FROM TimeLamViec WHERE Id = '" + name + "'", myDb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Double TotalTime1 = 0;
            Double TotalTime2 = 0;
            Double TotalTime3 = 0;

            if (table.Rows[0]["TimeStart1"].ToString().Trim() != "" && table.Rows[0]["TimeEnd1"].ToString().Trim() != "")
            {
                DateTime t1 = Convert.ToDateTime(table.Rows[0]["TimeStart1"].ToString().Trim());
                DateTime t2 = Convert.ToDateTime(table.Rows[0]["TimeEnd1"].ToString().Trim());
                TimeSpan ts = t1.Subtract(t2);
                TotalTime1 = Convert.ToDouble(ts.TotalHours.ToString());
            }
            if (table.Rows[0]["TimeStart2"].ToString().Trim() != "" && table.Rows[0]["TimeEnd2"].ToString().Trim() != "")
            {
                DateTime t1 = Convert.ToDateTime(table.Rows[0]["TimeStart2"].ToString().Trim());
                DateTime t2 = Convert.ToDateTime(table.Rows[0]["TimeEnd2"].ToString().Trim());
                TimeSpan ts = t1.Subtract(t2);
                TotalTime2 = Convert.ToDouble(ts.TotalHours.ToString());
            }
            if (table.Rows[0]["TimeStart3"].ToString().Trim() != "" && table.Rows[0]["TimeEnd3"].ToString().Trim() != "")
            {
                DateTime t1 = Convert.ToDateTime(table.Rows[0]["TimeStart3"].ToString().Trim());
                DateTime t2 = Convert.ToDateTime(table.Rows[0]["TimeEnd3"].ToString().Trim());
                TimeSpan ts = t1.Subtract(t2);
                TotalTime3 = Convert.ToDouble(ts.TotalHours.ToString());
            }
            return TotalTime1 + TotalTime2 + TotalTime3;
        }

        public int TinhTien()
        {
            int LuongMacDinh = 0;
            int i = Convert.ToInt32(TotalTimeLamViec());
            if (i > 8)
            {
                int x = i - 8;
                LuongMacDinh = 400000 + 50000 * x;
            }
            if (i < 8)
            {
                int x = 8 - i;
                LuongMacDinh = 400000 - 100000 * x;
            }
            if (LuongMacDinh < 0)
                LuongMacDinh = 0;
            return LuongMacDinh;
        }

        public void UpdateLuong()
        {
            int ID = login.IDKey;
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "Monday")
                idl.updateLuongThu2(ID, TinhTien());
            if (thu == "Tuesday")
                idl.updateLuongThu3(ID, TinhTien());
            if (thu == "Wednesday")
                idl.updateLuongThu4(ID, TinhTien());
            if (thu == "Thursday")
                idl.updateLuongThu5(ID, TinhTien());
            if (thu == "Friday")
                idl.updateLuongThu6(ID, TinhTien());
            if (thu == "Saturday")
                idl.updateLuongThu7(ID, TinhTien());
            if (thu == "Sunday")
                idl.updateLuongCN(ID, TinhTien());
        }


        private void buttonSaveWord_Click_1(object sender, EventArgs e)
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
                headerRange.Text = "LƯƠNG NHÂN VIÊN\n" + time;



                Range footersRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footersRange.Fields.Add(footersRange, WdFieldType.wdFieldPage);
                footersRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                footersRange.Font.ColorIndex = WdColorIndex.wdBlack;   // Màu
                footersRange.Font.Bold = 2;        // Độ Đậm Chữ
                footersRange.Font.Size = 16;
                footersRange.Text = "TP.HCM, " + time;
                footersRange.Text = "\n";

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
                tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
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
            object filename = @"D:\LuongNhanVien.docx";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);
        }

        private void buttonPrint_Click_1(object sender, EventArgs e)
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
