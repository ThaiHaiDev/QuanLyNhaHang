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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        public static int ID;
        NhanVien nhanvien = new NhanVien();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (radioButtonQL.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM QuanLy WHERE UserName = @User and PassWord =@Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUser.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPass.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                string h = DateTime.Now.Hour.ToString();
                int HourInt = Convert.ToInt32(h);
                if (HourInt >= 7 && HourInt <= 11)
                {
                    if (textBoxUser.Text == "haiql1")
                    {
                        MessageBox.Show("Khong phai ca lam cua quan ly 1.");
                    }
                    else if ((table.Rows.Count > 0))
                    {
                        MainQuanLy form1 = new MainQuanLy();
                        form1.Show(this);
                        //this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (textBoxUser.Text == "haiql2")
                    {
                        MessageBox.Show("Khong phai ca lam cua quan ly 2.");
                    }
                    else if ((table.Rows.Count > 0))
                    {
                        MainQuanLy form1 = new MainQuanLy();
                        form1.Show(this);
                        //this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (radioButtonNV.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE UserName = @User and PassWord =@Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUser.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPass.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    ID = Convert.ToInt32(table.Rows[0]["Id"].ToString());
                    MainNhanVien form1 = new MainNhanVien();
                    form1.labelIDNV.Text = ("ID Nhân Viên Truy Cập: " + ID);
                    form1.Show(this);
                    //this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxUser.Text = "UserName";
                textBoxUser.ForeColor = Color.Black;
            }
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "UserName")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "PassWord";
                textBoxPass.ForeColor = Color.Black;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "PassWord")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.Black;
            }
        }
        int flag = 0;
        private void pictureBoxAnPass_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                textBoxPass.UseSystemPasswordChar = false;
                flag = 1;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                flag = 0;
            }
        }
        public int IDKey = ID;

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            textBoxUser.ForeColor = Color.Black;
            textBoxUser.Text = "UserName";
            textBoxUser.Leave += new EventHandler(textBoxUser_Leave);
            textBoxUser.Enter += new EventHandler(textBoxUser_Enter);

            textBoxPass.ForeColor = Color.Black;
            textBoxPass.Text = "PassWord";
            textBoxPass.Leave += new EventHandler(textBoxPass_Leave);
            textBoxPass.Enter += new EventHandler(textBoxPass_Enter);
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBoxPass.BackColor = SystemColors.Control;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBoxUser.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
    }
}
