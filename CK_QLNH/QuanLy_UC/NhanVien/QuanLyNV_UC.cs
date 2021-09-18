using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
    public partial class QuanLyNV_UC : UserControl
    {
        public QuanLyNV_UC()
        {
            InitializeComponent();
        }
        NhanVien nhanvien = new NhanVien();
        AccountNV acc = new AccountNV();
        DataBase db = new DataBase();
        IDLamViec idl = new IDLamViec();
        
        private void textBoxSearchname_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchname.Text == "")
            {
                textBoxSearchname.Text = "Nhập Tên";
                textBoxSearchname.ForeColor = Color.Black;
            }
        }

        private void textBoxSearchname_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchname.Text == "Nhập Tên")
            {
                textBoxSearchname.Text = "";
                textBoxSearchname.ForeColor = Color.Black;
            }
        }
        
        private void QuanLyNV_UC_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT NhanVien.Id as N'Mã Số NV', NhanVien.TenNV as N'Tên', NhanVien.HoNV as N'Họ', ListNV_.NgaySinhNV as N'Ngày Sinh', GioiTinhNV as N'Giới Tính', DiaChiNV as N'Địa CHỉ', SDTNV as N'Số Điện Thoại', ListNV_.CMND, ListNV_.Gmail, ListNV_.HinhNV as N'Hình Ảnh' " +
                "FROM ListNV_   RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id ORDER BY  N'Tên'"));

            textBoxSearchname.ForeColor = Color.Black;
            textBoxSearchname.Text = "Nhập Tên";
            textBoxSearchname.Leave += new EventHandler(textBoxSearchname_Leave);
            textBoxSearchname.Enter += new EventHandler(textBoxSearchname_Enter);
        }
        public void fillGrid(SqlCommand command)
        {

            dataGridViewDanhSachNV.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewDanhSachNV.RowTemplate.Height = 80;
            dataGridViewDanhSachNV.DataSource = nhanvien.getNhanVien(command);
            // column 7 is the image column index
            picCol = (DataGridViewImageColumn)dataGridViewDanhSachNV.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewDanhSachNV.AllowUserToAddRows = false;

            // show the total students depending on dgv
            //labelTotalStudents.Text = "Total Students: " + DataGridViewStdList.Rows.Count;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearchname.Text;
            if (search.Trim() == "Nhập Tên")
            {
                MessageBox.Show("Nhập Tên", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT NhanVien.Id as N'Mã Số NV', NhanVien.TenNV as N'Tên', NhanVien.HoNV as N'Họ', ListNV_.NgaySinhNV as N'Ngày Sinh', GioiTinhNV as N'Giới Tính', DiaChiNV as N'Địa CHỉ', SDTNV as N'Số Điện Thoại', ListNV_.CMND, ListNV_.Gmail, ListNV_.HinhNV as N'Hình Ảnh' " +
                    " FROM ListNV_   RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id WHERE CONCAT(NhanVien.TenNV,NhanVien.Id) LIKE '%" + textBoxSearchname.Text + "%'";
                SqlCommand command = new SqlCommand(query);
                fillGrid(command);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int NhanVienId = Convert.ToInt32(textBoxSearchname.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Studen", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (nhanvien.deleteNhanVien(NhanVienId))
                    {
                        acc.deleteAccount(NhanVienId);
                        nhanvien.deleteChiaCa(NhanVienId);
                        nhanvien.deleteLuongNV(NhanVienId);
                        nhanvien.deleteTimeLV(NhanVienId);
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("SELECT NhanVien.Id as N'Mã Số NV', NhanVien.TenNV as N'Tên', NhanVien.HoNV as N'Họ', ListNV_.NgaySinhNV as N'Ngày Sinh', GioiTinhNV as N'Giới Tính', DiaChiNV as N'Địa CHỉ', SDTNV as N'Số Điện Thoại', ListNV_.CMND, ListNV_.Gmail, ListNV_.HinhNV as N'Hình Ảnh' " +
                "FROM ListNV_   RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id"));
        }

        private void dataGridViewDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxSearchname.Text = dataGridViewDanhSachNV.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonResestLuong_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand(" SELECT Id FROM TimeLamViec", db.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                idl.updateTimeDayNew(Convert.ToInt32(table.Rows[i][0].ToString()));
            }
            MessageBox.Show("Đã Resest Thời Gian Làm Việc Cho Ngày Mới");

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
                headerRange.Text = "DANH SÁCH NHÂN VIÊN\n" + time;



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
            object filename = @"D:\DanhSchNhanVien.docx";
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


        private void buttonChiaCa_Click(object sender, EventArgs e)
        {
            ChiaCaForm chiaca = new ChiaCaForm();
            chiaca.Show(this);
        }

        private void buttonthemnv_Click(object sender, EventArgs e)
        {
            ThemNVForm themnv = new ThemNVForm();
            themnv.Show(this);
            
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
           
            if(comboBoxSort.Text=="Theo Tên")
            {
                fillGrid(new SqlCommand("SELECT NhanVien.Id as N'Mã Số NV', NhanVien.TenNV as N'Tên', NhanVien.HoNV as N'Họ', ListNV_.NgaySinhNV as N'Ngày Sinh', GioiTinhNV as N'Giới Tính', DiaChiNV as N'Địa CHỉ', SDTNV as N'Số Điện Thoại', ListNV_.CMND, ListNV_.Gmail, ListNV_.HinhNV as N'Hình Ảnh' " +
                "FROM ListNV_   RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id ORDER BY  N'Tên'"));
            }    
            else if(comboBoxSort.Text=="Nhân Viên Mới")
            {
                fillGrid(new SqlCommand("SELECT NhanVien.Id as N'Mã Số NV', NhanVien.TenNV as N'Tên', NhanVien.HoNV as N'Họ', ListNV_.NgaySinhNV as N'Ngày Sinh', GioiTinhNV as N'Giới Tính', DiaChiNV as N'Địa CHỉ', SDTNV as N'Số Điện Thoại', ListNV_.CMND, ListNV_.Gmail, ListNV_.HinhNV as N'Hình Ảnh' " +
               "FROM ListNV_   RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id "));
            }    
            else if(comboBoxSort.Text=="Giới Tính Nam")
            {
                fillGrid(new SqlCommand("SELECT NhanVien.Id as N'Mã Số NV', NhanVien.TenNV as N'Tên', NhanVien.HoNV as N'Họ', ListNV_.NgaySinhNV as N'Ngày Sinh', GioiTinhNV as N'Giới Tính', DiaChiNV as N'Địa CHỉ', SDTNV as N'Số Điện Thoại', ListNV_.CMND, ListNV_.Gmail, ListNV_.HinhNV as N'Hình Ảnh' " +
               "FROM ListNV_   RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id WHERE GioiTinhNV = 'Male'"));
            }    
            else
            {
                fillGrid(new SqlCommand("SELECT NhanVien.Id as N'Mã Số NV', NhanVien.TenNV as N'Tên', NhanVien.HoNV as N'Họ', ListNV_.NgaySinhNV as N'Ngày Sinh', GioiTinhNV as N'Giới Tính', DiaChiNV as N'Địa CHỉ', SDTNV as N'Số Điện Thoại', ListNV_.CMND, ListNV_.Gmail, ListNV_.HinhNV as N'Hình Ảnh' " +
              "FROM ListNV_   RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id WHERE GioiTinhNV = 'Female'"));
            }    
        }

        
    }
}
