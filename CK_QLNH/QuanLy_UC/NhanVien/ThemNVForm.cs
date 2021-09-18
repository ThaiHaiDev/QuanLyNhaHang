using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_QLNH
{
    public partial class ThemNVForm : Form
    {
        public ThemNVForm()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        IDLamViec idl = new IDLamViec();
        AccountNV tk = new AccountNV();
        NhanVien nv = new NhanVien();
        QuanLyNV_UC ql = new QuanLyNV_UC();
        public static int dem;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string lname = textBoxLName.Text;
            string fname = textBoxFName.Text;
            DateTime bdate = DateTimePickerBirth.Value;
            MemoryStream picture = new MemoryStream();
            
            SqlCommand commandCheckUsername = new SqlCommand("SELECT Id, TenNV, HoNV FROM NhanVien WHERE UserName = @username");
            commandCheckUsername.Parameters.Add("@username", SqlDbType.VarChar).Value = textBoxUserName.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            commandCheckUsername.Connection = db.GetConnection;
            adapter.SelectCommand = commandCheckUsername;


            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Username đã tồn tại", "Username Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (tk.insertAccount(username, password, fname, lname))
            {
                //dem++;
                SqlCommand command = new SqlCommand(" SELECT Id FROM NhanVien", db.GetConnection);
                SqlDataAdapter adapterc = new SqlDataAdapter(command);
                DataTable tablec = new DataTable();
                adapterc.Fill(tablec);
                dem = Convert.ToInt32(tablec.Rows[Convert.ToInt32(tablec.Rows.Count.ToString()) - 1]["Id"].ToString());
                idl.insertStudent(dem, "", "", "", "", "", "", "");
                idl.insertTime(dem);
                idl.insertLuong(dem);
                PictureBoxNV.Image.Save(picture, PictureBoxNV.Image.RawFormat);
                nv.insertNhanVien(dem, fname, lname,bdate, "", "", "", picture);

                MessageBox.Show("New Account Add", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        bool verif()
        {
            if ((textBoxUserName.Text.Trim() == "") || (textBoxPassword.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ThemNVForm_Load(object sender, EventArgs e)
        {
            textBoxUserName.ForeColor = Color.Black;
            textBoxUserName.Text = "New UserName";
            textBoxUserName.Leave += new EventHandler(textBoxUserName_Leave);
            textBoxUserName.Enter += new EventHandler(textBoxUserName_Enter);

            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Text = "PassWord";
            textBoxPassword.Leave += new EventHandler(textBoxPassword_Leave);
            textBoxPassword.Enter += new EventHandler(textBoxPassword_Enter);

            textBoxFName.ForeColor = Color.Black;
            textBoxFName.Text = "First Name";
            textBoxFName.Leave += new EventHandler(textBoxFName_Leave);
            textBoxFName.Enter += new EventHandler(textBoxFName_Enter);

            textBoxLName.ForeColor = Color.Black;
            textBoxLName.Text = "Last Name";
            textBoxLName.Leave += new EventHandler(textBoxLName_Leave);
            textBoxLName.Enter += new EventHandler(textBoxLName_Enter);
        }

        private void textBoxFName_Leave(object sender, EventArgs e)
        {
            if (textBoxFName.Text == "")
            {
                textBoxFName.Text = "First Name";
                textBoxFName.ForeColor = Color.Black;
            }
        }

        private void textBoxFName_Enter(object sender, EventArgs e)
        {
            if (textBoxFName.Text == "First Name")
            {
                textBoxFName.Text = "";
                textBoxFName.ForeColor = Color.Black;
            }
        }

        private void textBoxLName_Leave(object sender, EventArgs e)
        {
            if (textBoxLName.Text == "")
            {
                textBoxLName.Text = "Last Name";
                textBoxLName.ForeColor = Color.Black;
            }
        }

        private void textBoxLName_Enter(object sender, EventArgs e)
        {
            if (textBoxLName.Text == "Last Name")
            {
                textBoxLName.Text = "";
                textBoxLName.ForeColor = Color.Black;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "New UserName";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "New UserName")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "PassWord";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "PassWord")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxNV.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
