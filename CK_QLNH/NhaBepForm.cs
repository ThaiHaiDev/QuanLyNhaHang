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
    public partial class NhaBepForm : Form
    {
        public NhaBepForm()
        {
            InitializeComponent();
        }
        BANAN banan = new BANAN();
        Ban_Form ban = new Ban_Form();
        public void fillGrid(SqlCommand command)
        {

            dataGridViewOder.ReadOnly = true;
            dataGridViewOder.DataSource = banan.getBanAn(command);
            dataGridViewOder.AllowUserToAddRows = false;
        }
        private void NhaBepForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT idban AS N'Mã Bàn', tenmonhd AS N'Tên Món', soluong AS N'Số Lượng', giathanh AS N'Giá Thành', thoigian AS N'Thời Gian' FROM HoaDon WHERE idban = '" + ban.IdBanKey.Trim() + "'"));
        }
    }
}
