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
    public partial class TinhTien_Form : Form
    {
        public TinhTien_Form()
        {
            InitializeComponent();
        }
        BANAN ban = new BANAN();
        DataBase mydb = new DataBase();
        HoaDon hoadon = new HoaDon();
        public static int Tien;
        public static int TienB;
        private void TinhTien_Form_Load(object sender, EventArgs e)
        {
            comboBoxIdBan.DataSource = ban.getBanTrong();
            comboBoxIdBan.DisplayMember = "Id";
            comboBoxIdBan.ValueMember = "Id";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string name = comboBoxIdBan.Text.Trim();

            SqlCommand commandban = new SqlCommand(" SELECT Id, giaban FROM QLBanAn WHERE Id = '" + name + "'", mydb.GetConnection);
            SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            DataTable tableban = new DataTable();
            adapterban.Fill(tableban);


            ban.updateBanAnTrong(name, 1);
            ban.insertDoanhThuBan(name, Convert.ToInt32(tableban.Rows[0]["giaban"].ToString()), Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
            hoadon.deleteHoaDon(name);
            MessageBox.Show("Đã Thanh Toán", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (radioButtonFrint.Checked == true)
            {
                // Tạo đường dẫn đến word
                _Application oWord = new Microsoft.Office.Interop.Word.Application();
                //Tạo một Document
                _Document wordDoc = oWord.Documents.Add();
                int ColumnCount = dataGridViewHoaDon.Columns.Count;
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
                    headerRange.Text = "HÓA ĐƠN TIỀN ĂN\n" + time;



                    Range footersRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footersRange.Fields.Add(footersRange, WdFieldType.wdFieldPage);
                    footersRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    footersRange.Font.ColorIndex = WdColorIndex.wdBlack;   // Màu
                    footersRange.Font.Bold = 2;        // Độ Đậm Chữ
                    footersRange.Font.Size = 16;
                    footersRange.Text = "TP.HCM, " + time + "\n\n";
                    footersRange.Text = "\n";


                    section.Borders.Enable = 1;
                    section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                    section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                    section.Borders.OutsideColor = WdColor.wdColorBlack;

                }

                // Tạo bảng danh sách sinh viên
                Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewHoaDon.Rows.Count + 1, dataGridViewHoaDon.Columns.Count, ref missing, ref missing);
                //Xuất hiện khung table
                tableST.Borders.Enable = 1;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewHoaDon.Columns[c].HeaderText;
                    tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;
                    tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
                }
                for (int i = 2; i <= tableST.Rows.Count; i++)
                {

                    for (int j = 1; j < tableST.Columns.Count + 1; j++)
                    {

                        //Lưu text
                        tableST.Rows[i].Cells[j].Range.Text = dataGridViewHoaDon.Rows[i - 2].Cells[j - 1].Value.ToString();
                        tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                        tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                    }
                }
                para1.Range.Text = "\nTiền Bàn Thanh Toán Là: " + TienB;
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                para1.Range.Text = "\nTổng Bill Thanh Toán Là: " + Tien;
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();
                // Lưu thông tin 
                object filename = @"D:\HoaDonCuaKhach.docx";
                wordDoc.SaveAs2(ref filename);
                wordDoc.Close();
                oWord.Quit();
                MessageBox.Show("Đã In và Thanh Toán Hóa Đơn", "Thông báo", MessageBoxButtons.OK);
            }

        }


        public void fillGrid(SqlCommand command)
        {

            dataGridViewHoaDon.ReadOnly = true;
            dataGridViewHoaDon.DataSource = hoadon.getHoaDon(command);
            dataGridViewHoaDon.AllowUserToAddRows = false;

        }
        private void buttonXemHoaDon_Click(object sender, EventArgs e)
        {
            string name = comboBoxIdBan.Text.Trim();
            SqlCommand command = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', tenmonhd as N'Tên Món', soluong as N'Số Lượng Món', giathanh as N'Giá Tổng', thoigian as N'Thời Gian' FROM HoaDon WHERE idban = '" + name + "'", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            fillGrid(new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', tenmonhd as N'Tên Món', soluong as N'Số Lượng Món', giathanh as N'Giá Tổng', thoigian as N'Thời Gian' FROM HoaDon WHERE idban = '" + name + "'"));

            int tien = 0;
            SqlCommand commandban = new SqlCommand(" SELECT Id, giaban FROM QLBanAn WHERE Id = '" + name + "'", mydb.GetConnection);
            SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            DataTable tableban = new DataTable();
            adapterban.Fill(tableban);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                tien = tien + Convert.ToInt32(table.Rows[i]["Giá Tổng"].ToString());
            }

            labelTienBan.Text = "Giá Tiền Bàn Là: " + (Convert.ToInt32(tableban.Rows[0]["giaban"].ToString()));
            labelTongTien.Text = "Tổng Tiền Thanh Toán Là: " + (Convert.ToInt32(tableban.Rows[0]["giaban"].ToString()) + tien);
            Tien = (Convert.ToInt32(tableban.Rows[0]["giaban"].ToString()) + tien);
            TienB = (Convert.ToInt32(tableban.Rows[0]["giaban"].ToString()));
        }
    }
}
