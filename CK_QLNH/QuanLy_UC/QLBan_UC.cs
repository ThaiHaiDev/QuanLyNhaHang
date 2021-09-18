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
    public partial class QLBan_UC : UserControl
    {
        public QLBan_UC()
        {
            InitializeComponent();
        }
        BANAN banan = new BANAN();

        public void fillGrid(SqlCommand command)
        {

            dataGridViewQlBan.ReadOnly = true;

            dataGridViewQlBan.RowTemplate.Height = 80;
            dataGridViewQlBan.DataSource = banan.getBanAn(command);


            dataGridViewQlBan.AllowUserToAddRows = false;

            // show the total students depending on dgv
            labelSoBan.Text = "So Ban An: " + dataGridViewQlBan.Rows.Count;
        }
        private void ButtonAddBanAn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string id = textBoxIdBan.Text;
                //int id = Convert.ToInt32(textBoxCourseID.Text);
                string tenban = TextBoxTenBan.Text;
                int soluong = Convert.ToInt32(TextBoxSL.Text);
                float giaban = Convert.ToInt32(textBoxGiaThanh.Text);
                int tinhtrang = Convert.ToInt32(textBoxTinhTrang.Text);
                if (tenban.Trim() == "")
                {
                    MessageBox.Show("Add a Ten Ban An", "Add Ban An", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (banan.checkTenBanAn(tenban))
                {
                    if (banan.insertBanAn(id, tenban, soluong, giaban, tinhtrang))
                    {
                        MessageBox.Show("New Ban An Inserted", "Add Ban An", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ban An Not Inserted", "Add Ban An", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This Ten Ban An Already Exists", "Add Ban An", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Them Ban An", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn"));
            YeuCau();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            

            try
            {
                //int Idbanan = Convert.ToInt32(TextBoxSL.Text);
                string tenban = TextBoxTenBan.Text;
                int soluong = Convert.ToInt32(TextBoxSL.Text);
                float giaban = Convert.ToInt32(textBoxGiaThanh.Text);
                int tinhtrang = Convert.ToInt32(textBoxTinhTrang.Text);
                if (banan.updateBanAn(tenban, soluong, giaban, tinhtrang))
                {
                    MessageBox.Show("Ban An Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Ban An", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Ban An", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn"));
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string tenban = TextBoxTenBan.Text;
                if (MessageBox.Show("Are You Sure You Want To Remove This Ban An", "Delete Ban An", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (banan.deleteBanAn(tenban))
                    {
                        MessageBox.Show("Ban An Delete", "Remove Ban An", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ban An Not Delete", "Remove Ban An", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Remove Ban An", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn"));
            YeuCau();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int s = 1 + dataGridViewQlBan.Rows.Count;
            textBoxIdBan.Text = "BA" + s;
            textBoxIdBan.Enabled = false;
            
            buttonEdit.Enabled = false;
            ButtonRemove.Enabled = false;
            buttonTim.Enabled = false;
            textBoxSearch.Enabled = false;

            YeuCau();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            if (search.Trim() == "Nhập Tên_SL_Giá")
            {
                MessageBox.Show("Nhập Tên_SL_Giá", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn WHERE CONCAT(tenban,soluong,giaban) LIKE '%" + textBoxSearch.Text + "%'");
                fillGrid(command);
                TextBoxTenBan.Text = dataGridViewQlBan.CurrentRow.Cells[1].Value.ToString();
                TextBoxSL.Text = dataGridViewQlBan.CurrentRow.Cells[2].Value.ToString();
                textBoxGiaThanh.Text = dataGridViewQlBan.CurrentRow.Cells[3].Value.ToString();
                textBoxTinhTrang.Text = dataGridViewQlBan.CurrentRow.Cells[4].Value.ToString();
            }
            
        }

        private void QLBan_UC_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT Id as N'Mã Bàn Ăn', tenban as N'Tên Bàn', soluong as N'Số Lượng Khách', giaban as N'Giá Bàn', tinhtrang as N'Tình Trạng' FROM QLBanAn"));
            textBoxIdBan.ForeColor = Color.Black;
            textBoxIdBan.Text = "New ID";
            textBoxIdBan.Leave += new EventHandler(textBoxIdBan_Leave);
            textBoxIdBan.Enter += new EventHandler(textBoxIdBan_Enter);
            YeuCau();
        }

        public void YeuCau()
        {
            

            TextBoxTenBan.ForeColor = Color.Black;
            TextBoxTenBan.Text = "Tên Bàn";
            TextBoxTenBan.Leave += new EventHandler(TextBoxTenBan_Leave);
            TextBoxTenBan.Enter += new EventHandler(TextBoxTenBan_Enter);

            TextBoxSL.ForeColor = Color.Black;
            TextBoxSL.Text = "Số Lượng";
            TextBoxSL.Leave += new EventHandler(TextBoxSL_Leave);
            TextBoxSL.Enter += new EventHandler(TextBoxSL_Enter);

            textBoxGiaThanh.ForeColor = Color.Black;
            textBoxGiaThanh.Text = "Giá Thành";
            textBoxGiaThanh.Leave += new EventHandler(textBoxGiaThanh_Leave);
            textBoxGiaThanh.Enter += new EventHandler(textBoxGiaThanh_Enter);

            textBoxSearch.ForeColor = Color.Black;
            textBoxSearch.Text = "Nhập Tên_SL_Giá";
            textBoxSearch.Leave += new EventHandler(textBoxSearch_Leave);
            textBoxSearch.Enter += new EventHandler(textBoxSearch_Enter);

            textBoxTinhTrang.ForeColor = Color.Black;
            textBoxTinhTrang.Text = "Tình Trạng";
            textBoxTinhTrang.Leave += new EventHandler(textBoxTinhTrang_Leave);
            textBoxTinhTrang.Enter += new EventHandler(textBoxTinhTrang_Enter);
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxIdBan.Text = "";
            TextBoxTenBan.Text = "";
            TextBoxSL.Text = "";
            textBoxGiaThanh.Text = "";
            textBoxTinhTrang.Text = "";
            buttonEdit.Enabled = true;
            ButtonRemove.Enabled = true;
            buttonTim.Enabled = true;
            textBoxSearch.Enabled = true;

        }

        private void textBoxIdBan_Leave(object sender, EventArgs e)
        {
            if (textBoxIdBan.Text == "")
            {
                textBoxIdBan.Text = "New ID";
                textBoxIdBan.ForeColor = Color.Black;
            }
        }

        private void textBoxIdBan_Enter(object sender, EventArgs e)
        {
            if (textBoxIdBan.Text == "New ID")
            {
                textBoxIdBan.Text = "";
                textBoxIdBan.ForeColor = Color.Black;
            }
        }

        private void TextBoxTenBan_Leave(object sender, EventArgs e)
        {
            if (TextBoxTenBan.Text == "")
            {
                TextBoxTenBan.Text = "Tên Bàn";
                TextBoxTenBan.ForeColor = Color.Black;
            }
        }

        private void TextBoxTenBan_Enter(object sender, EventArgs e)
        {
            if (TextBoxTenBan.Text == "Tên Bàn")
            {
                TextBoxTenBan.Text = "";
                TextBoxTenBan.ForeColor = Color.Black;
            }
        }

        private void TextBoxSL_Leave(object sender, EventArgs e)
        {
            if (TextBoxSL.Text == "")
            {
                TextBoxSL.Text = "Số Lượng";
                TextBoxSL.ForeColor = Color.Black;
            }
        }

        private void TextBoxSL_Enter(object sender, EventArgs e)
        {
            if (TextBoxSL.Text == "Số Lượng")
            {
                TextBoxSL.Text = "";
                TextBoxSL.ForeColor = Color.Black;
            }
        }

        private void textBoxGiaThanh_Leave(object sender, EventArgs e)
        {
            if (textBoxGiaThanh.Text == "")
            {
                textBoxGiaThanh.Text = "Giá Thành";
                textBoxGiaThanh.ForeColor = Color.Black;
            }
        }

        private void textBoxGiaThanh_Enter(object sender, EventArgs e)
        {
            if (textBoxGiaThanh.Text == "Giá Thành")
            {
                textBoxGiaThanh.Text = "";
                textBoxGiaThanh.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Nhập Tên_SL_Giá";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Nhập Tên_SL_Giá")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void dataGridViewQlBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxTenBan.Text = dataGridViewQlBan.CurrentRow.Cells[1].Value.ToString();
            TextBoxSL.Text = dataGridViewQlBan.CurrentRow.Cells[2].Value.ToString();
            textBoxGiaThanh.Text = dataGridViewQlBan.CurrentRow.Cells[3].Value.ToString();
            textBoxTinhTrang.Text= dataGridViewQlBan.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBoxTinhTrang_Leave(object sender, EventArgs e)
        {
            if (textBoxTinhTrang.Text == "")
            {
                textBoxTinhTrang.Text = "Tình Trạng";
                textBoxTinhTrang.ForeColor = Color.Black;
            }
        }

        private void textBoxTinhTrang_Enter(object sender, EventArgs e)
        {
            if (textBoxTinhTrang.Text == "Tình Trạng")
            {
                textBoxTinhTrang.Text = "";
                textBoxTinhTrang.ForeColor = Color.Black;
            }
        }
    }
}
