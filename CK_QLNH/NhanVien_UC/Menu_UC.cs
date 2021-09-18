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
    public partial class Menu_UC : UserControl
    {
        public Menu_UC()
        {
            InitializeComponent();
        }

        MONAN monan = new MONAN();
        public void fillGridM(SqlCommand command)
        {
            dataGridViewThucDon.ReadOnly = true;
            dataGridViewThucDon.DataSource = monan.getMonAn(command);
            dataGridViewThucDon.AllowUserToAddRows = false;
        }


        private void Menu_UC_Load(object sender, EventArgs e)
        {
            fillGridM(new SqlCommand("Select Id AS N'Mã Món Ăn', tenmon AS N'Tên Món', giamon AS N'Giá Món', nguyenlieu AS N'Nguyên Liệu', soluong AS N'Số Lượng'  FROM QLMonAn"));

        }


    }
}
