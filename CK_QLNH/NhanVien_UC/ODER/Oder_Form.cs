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
    public partial class Oder_Form : Form
    {
        public Oder_Form()
        {
            InitializeComponent();
        }
        BANAN banan = new BANAN();
        HoaDon hoadon = new HoaDon();
        DoanhThu doanhthu = new DoanhThu();
        DataBase db = new DataBase();
        MONAN monan = new MONAN();
        Ban_Form ban = new Ban_Form();
        public void fillGrid(SqlCommand command)
        {

            dataGridViewOder.ReadOnly = true;
            dataGridViewOder.DataSource = banan.getBanAn(command);
            dataGridViewOder.AllowUserToAddRows = false;
        }
        private void buttonTaoHD_Click(object sender, EventArgs e)
        {
            //int s = 1 + dataGridViewOder.Rows.Count;
            //textBoxIDHoaDon.Text = "HD" + s;
            //textBoxIDHoaDon.Enabled = false;
            //buttonEdit.Enabled = false;
            //ButtonRemove.Enabled = false;

            //comboBoxTenMon.Text = "";
            //textBoxSL.Text = "";
            //textBoxGia.Text = "";
            //DateTimePickerBirthTG.Text = "";
        }

        private void ButtonLuuHD_Click(object sender, EventArgs e)
        {
            try
            {

                string tenmon = comboBoxTenMon.Text.Trim();

                SqlCommand command = new SqlCommand("SELECT tenmon,soluong FROM QLMonAn WHERE tenmon = '" + tenmon + "'", db.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                int sl = Convert.ToInt32(table.Rows[0][1].ToString());
                int slcheck = Convert.ToInt32(table.Rows[0][1].ToString()) - Convert.ToInt32(textBoxSL.Text);

                if (sl <= 0)
                {
                    MessageBox.Show("Món Ăn Này Tạm Hết Số Lượng Bán Trong Ngày. Bạn Vui Lòng Oder Món Khác");
                }
                else if (slcheck < 0)
                {
                    MessageBox.Show("Món Ăn Này Không Đủ Số Lượng Để Bạn Oder. Nhà Hàng Chỉ Còn " + sl + " Phần. Bạn Có Thể Oder Số Lượng Khác Hoặc Vui Lòng Gọi Món Mới");
                }
                else
                {

                    string idban = textBoxIdBan.Text;
                    string tenmonhd = comboBoxTenMon.Text.Trim();
                    int soluong = Convert.ToInt32(textBoxSL.Text);
                    float giathanh = Convert.ToInt32(textBoxGia.Text);
                    DateTime thoigian = DateTimePickerBirthTG.Value;

                    if (hoadon.insertHoaDon(ban.IdBanKey.Trim(), tenmonhd, soluong, giathanh, thoigian))
                    {
                        doanhthu.insertDoanhThu(ban.IdBanKey.Trim(), tenmonhd, soluong, giathanh, thoigian);
                        monan.updateSLMonAn(tenmon, slcheck);
                        banan.updateBanAnTrong(ban.IdBanKey.Trim(), 0);
                        MessageBox.Show("Oder Being Inserted", "Add Oder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Oder Not Inserted", "Add Oder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    fillGrid(new SqlCommand("SELECT idban as N'Mã Bàn Ăn', tenmonhd as N'Tên Món', soluong as N'Số Lượng Món', giathanh as N'Giá Tổng', thoigian as N'Thời Gian' FROM HoaDon WHERE idban = '" + ban.IdBanKey.Trim() + "'"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Oder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comboBoxTenMon.Text = "";
            textBoxGia.Text = "";
            textBoxSL.Text = "";


            string name = textBoxIdBan.Text;
            SqlCommand command1 = new SqlCommand(" SELECT idban as N'Mã Bàn Ăn', tenmonhd as N'Tên Món', soluong as N'Số Lượng Món', giathanh as N'Giá Tổng', thoigian as N'Thời Gian' FROM HoaDon WHERE idban = '" + name + "'", db.GetConnection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);

            int tien = 0;
            SqlCommand commandban = new SqlCommand(" SELECT Id, giaban FROM QLBanAn WHERE Id = '" + name + "'", db.GetConnection);
            SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            DataTable tableban = new DataTable();
            adapterban.Fill(tableban);

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                tien = tien + Convert.ToInt32(table1.Rows[i]["Giá Tổng"].ToString());
            }

            labelTongTien.Text = "Tổng Tiền Thanh Toán (Đã Tính Tiền Bàn) Là: " + (Convert.ToInt32(tableban.Rows[0]["giaban"].ToString()) + tien);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            try
            {
                string tenmonhd = comboBoxTenMon.Text;
                int soluong = Convert.ToInt32(textBoxSL.Text);
                float giathanh = Convert.ToInt32(textBoxGia.Text);
                DateTime thoigian = DateTimePickerBirthTG.Value;
                if (hoadon.updateHoaDon(tenmonhd, soluong, giathanh, thoigian))
                {
                    doanhthu.updateDoanhThu(tenmonhd, soluong, giathanh, thoigian);
                    MessageBox.Show("Mon An Information Updated", "Edit Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("a", "b", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Mon An", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT idban AS N'Mã Bàn', tenmonhd AS N'Tên Món', soluong AS N'Số Lượng', giathanh AS N'Giá Thành', thoigian AS N'Thời Gian' FROM HoaDon WHERE idban = '" + ban.IdBanKey.Trim() + "'"));

            comboBoxTenMon.Text = "";
            textBoxSL.Text = "";
            textBoxGia.Text = "";
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string tenm = comboBoxTenMon.Text;
                if (MessageBox.Show("Are You Sure You Want To Remove This Mon An", "Delete Mon An", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (hoadon.deleteMonAn(tenm))
                    {
                        doanhthu.deleteMonAn(tenm);
                        for (int i = 0; i < dataGridViewOder.Rows.Count; i++)
                        {
                            int k = Convert.ToInt32(dataGridViewOder.Rows[i].Cells[2].Value);
                            string name = dataGridViewOder.Rows[i].Cells[1].Value.ToString().Trim();
                            SqlCommand command = new SqlCommand("SELECT tenmon,soluong FROM QLMonAn WHERE tenmon = '" + name + "'", db.GetConnection);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            int sl = Convert.ToInt32(table.Rows[0][1].ToString());
                            monan.updateSLMonAn(name, sl + k);
                        }
                        MessageBox.Show("Mon An Delete", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mon An Not Delete", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("SELECT idban AS N'Mã Bàn', tenmonhd AS N'Tên Món', soluong AS N'Số Lượng', giathanh AS N'Giá Thành', thoigian AS N'Thời Gian' FROM HoaDon WHERE idban = '" + ban.IdBanKey.Trim() + "'"));

            comboBoxTenMon.Text = "";
            textBoxSL.Text = "";
            textBoxGia.Text = "";
        }



        private void buttonHuy_Click(object sender, EventArgs e)
        {



            string idban = textBoxIdBan.Text;
            if (MessageBox.Show("Are You Sure You Want To Remove This Mon An", "Delete Mon An", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hoadon.deleteHoaDon(idban);
                doanhthu.deleteHoaDon(idban);
                banan.updateBanAnTrong(ban.IdBanKey.Trim(), 1);
                for (int i = 0; i < dataGridViewOder.Rows.Count; i++)
                {
                    int k = Convert.ToInt32(dataGridViewOder.Rows[i].Cells[2].Value);
                    string name = dataGridViewOder.Rows[i].Cells[1].Value.ToString().Trim();
                    SqlCommand command = new SqlCommand("SELECT tenmon,soluong FROM QLMonAn WHERE tenmon = '" + name + "'", db.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    int sl = Convert.ToInt32(table.Rows[0][1].ToString());
                    monan.updateSLMonAn(name, sl + k);
                }
                MessageBox.Show("Mon An Delete", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            labelTongTien.Text = "";
            fillGrid(new SqlCommand("SELECT idban AS N'Mã Bàn', tenmonhd AS N'Tên Món', soluong AS N'Số Lượng', giathanh AS N'Giá Thành', thoigian AS N'Thời Gian' FROM HoaDon WHERE idban = '" + ban.IdBanKey.Trim() + "'"));
        }

        private void Oder_Form_Load(object sender, EventArgs e)
        {

            textBoxIdBan.Text = ban.IdBanKey.Trim();
            textBoxIdBan.Enabled = false;
            textBoxGia.Enabled = false;
            //lay thong tin tenmon
            comboBoxTenMon.DataSource = hoadon.getHoaDon(new SqlCommand("SELECT * FROM QLMonAn"));
            comboBoxTenMon.DisplayMember = "tenmon";
            comboBoxTenMon.ValueMember = "Id";

            fillGrid(new SqlCommand("SELECT idban AS N'Mã Bàn', tenmonhd AS N'Tên Món', soluong AS N'Số Lượng', giathanh AS N'Giá Thành', thoigian AS N'Thời Gian' FROM HoaDon WHERE idban = '" + ban.IdBanKey.Trim() + "'"));



        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã Chuyễn Cho Nhà Bếp");
            Close();
        }
        // Load Giá Tiền Khi Nhập Số Lượng 
        private void textBoxSL_TextChanged(object sender, EventArgs e)
        {
            int MonSelect = Convert.ToInt32(this.comboBoxTenMon.SelectedIndex.ToString().Trim());
            SqlCommand command = new SqlCommand("SELECT * FROM QLMonAn", db.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            double Price = Convert.ToDouble(table.Rows[MonSelect]["giamon"].ToString().Trim());
            if (textBoxSL.Text.Trim() != "")
            {
                int sl = Convert.ToInt32(textBoxSL.Text.Trim());
                textBoxGia.Text = Convert.ToString(sl * Price);
            }
        }

        private void dataGridViewOder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxIdBan.Text = dataGridViewOder.CurrentRow.Cells[0].Value.ToString();
            comboBoxTenMon.Text = dataGridViewOder.CurrentRow.Cells[1].Value.ToString();
            textBoxSL.Text = dataGridViewOder.CurrentRow.Cells[2].Value.ToString();
            textBoxGia.Text = dataGridViewOder.CurrentRow.Cells[3].Value.ToString();
            DateTimePickerBirthTG.Text = dataGridViewOder.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonNhaBep_Click(object sender, EventArgs e)
        {
            NhaBepForm re = new NhaBepForm();
            re.Show();
        }
    }
}
