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
    public partial class ThongTinNV_UC : UserControl
    {
        public ThongTinNV_UC()
        {
            InitializeComponent();
        }
        NhanVien nhanvien = new NhanVien();
        DataBase myDb = new DataBase();
        Login_Form login = new Login_Form();
        public int check = 0;
        AccountNV acc = new AccountNV();

        private void ThongTinNV_UC_Load(object sender, EventArgs e)
        {
            int name = login.IDKey;
            SqlCommand command = new SqlCommand(" SELECT NhanVien.Id, NhanVien.TenNV, NhanVien.HoNV, NgaySinhNV, GioiTinhNV, DiaChiNV, SDTNV, HinhNV, NhanVien.PassWord, CMND, Gmail FROM ListNV_  " +
                " RIGHT JOIN  NhanVien ON ListNV_.Id=NhanVien.Id WHERE NhanVien.Id = '" + name + "'", myDb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            TextBoxID.Text = name.ToString();
            if (table.Rows.Count > 0)
            {
                TextBoxFName.Text = table.Rows[0]["TenNV"].ToString();
                TextBoxLName.Text = table.Rows[0]["HoNV"].ToString();
                if (table.Rows[0]["GioiTinhNV"].ToString() == "Female    ")
                {
                    Female.Checked = true;
                }
                else
                {
                    Male.Checked = true;
                }
                TextBoxAddress.Text = table.Rows[0]["DiaChiNV"].ToString();
                TextBoxPhone.Text = table.Rows[0]["SDTNV"].ToString();
                textBoxDoiMK.Text = table.Rows[0]["PassWord"].ToString();
                textBoxCMND.Text = table.Rows[0]["CMND"].ToString();
                textBoxMail.Text = table.Rows[0]["Gmail"].ToString();
                if (table.Rows[0]["NgaySinhNV"].ToString().Trim() != "" && table.Rows[0]["HinhNV"].ToString().Trim() != "")
                {
                    DateTimePickerBirth.Value = (DateTime)table.Rows[0]["NgaySinhNV"];
                    byte[] pic = (byte[])table.Rows[0]["HinhNV"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxNV.Image = Image.FromStream(picture);
                }
            }

            if (textBoxCMND.Text == "")
            {
                TextBoxPhone.ForeColor = Color.Black;
                TextBoxPhone.Text = "Số Điện Thoại";
                TextBoxPhone.Leave += new EventHandler(TextBoxPhone_Leave);
                TextBoxPhone.Enter += new EventHandler(TextBoxPhone_Enter);

                TextBoxAddress.ForeColor = Color.Black;
                TextBoxAddress.Text = "Địa Chỉ";
                TextBoxAddress.Leave += new EventHandler(TextBoxAddress_Leave);
                TextBoxAddress.Enter += new EventHandler(TextBoxAddress_Enter);

                textBoxCMND.ForeColor = Color.Black;
                textBoxCMND.Text = "CMND";
                textBoxCMND.Leave += new EventHandler(textBoxCMND_Leave);
                textBoxCMND.Enter += new EventHandler(textBoxCMND_Enter);

                textBoxMail.ForeColor = Color.Black;
                textBoxMail.Text = "Gmail";
                textBoxMail.Leave += new EventHandler(textBoxMail_Leave);
                textBoxMail.Enter += new EventHandler(textBoxMail_Enter);

            }


        }
        bool verif()
        {
            if (
                 (TextBoxFName.Text.Trim() == "")
                || (TextBoxLName.Text.Trim() == "")
                || (TextBoxPhone.Text.Trim() == "")
                || (TextBoxAddress.Text.Trim() == "")
                || (textBoxCMND.Text.Trim() == "")
                || (textBoxMail.Text.Trim() == "")
                || (PictureBoxNV.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(TextBoxID.Text.Trim()) != login.IDKey)
            {
                MessageBox.Show("Bạn Không Có Quyền Edit ID Staff Khác", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int NhanVienID = Convert.ToInt32(TextBoxID.Text);
                    //string TenNV = 
                    if ((MessageBox.Show("Bạn có muốn xóa Nhân Viên này!!!", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (nhanvien.deleteNhanVien(NhanVienID))
                        {
                            acc.deleteAccount(NhanVienID);
                            nhanvien.deleteChiaCa(NhanVienID);
                            nhanvien.deleteLuongNV(NhanVienID);
                            nhanvien.deleteTimeLV(NhanVienID);
                            MessageBox.Show("Xóa Nhân Viên", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TextBoxID.Text = "";
                            TextBoxFName.Text = "";
                            TextBoxLName.Text = "";
                            TextBoxAddress.Text = "";
                            TextBoxPhone.Text = "";
                            DateTimePickerBirth.Value = DateTime.Now;
                            PictureBoxNV.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Không xóa nhân viên được", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Nhập tên Nhân Viên", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            MessageBox.Show("Bạn Đã Hết Quyền Truy Cập, Mời Bạn Logout", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBoxID.Text.Trim()) != login.IDKey)
            {
                MessageBox.Show("Bạn Không Có Quyền Edit ID Staff Khác", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id;
                string fname = TextBoxFName.Text;
                string lname = TextBoxLName.Text;
                DateTime bdate = DateTimePickerBirth.Value;
                string phone = TextBoxPhone.Text;
                string address = TextBoxAddress.Text;
                string cmnd = textBoxCMND.Text;
                string gmail = textBoxMail.Text;
                string gender = "Male";
                if (Female.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePickerBirth.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Staff Age Must Be Between 10 And 100 Year", "Incalid Birth Day", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (verif())
                {
                    try
                    {
                        id = Convert.ToInt32(TextBoxID.Text);
                        PictureBoxNV.Image.Save(pic, PictureBoxNV.Image.RawFormat);
                        if (nhanvien.updateNhanVien(id, fname, lname, bdate, gender, phone, address, pic, cmnd, gmail))
                        {
                            MessageBox.Show("Staff Information Updated", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void buttonDoiMK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBoxID.Text.Trim()) != login.IDKey)
            {
                MessageBox.Show("Bạn Không Có Quyền Edit ID Staff Khác", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id;
                string mkhau = textBoxDoiMK.Text;


                if (verif())
                {
                    try
                    {
                        id = Convert.ToInt32(TextBoxID.Text);

                        if (nhanvien.updatePassWord(id, mkhau))
                        {
                            MessageBox.Show("Staff Information Updated", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void TextBoxPhone_Leave(object sender, EventArgs e)
        {
            if (TextBoxPhone.Text == "")
            {
                TextBoxPhone.Text = "Số Điện Thoại";
                TextBoxPhone.ForeColor = Color.Black;
            }
        }

        private void TextBoxPhone_Enter(object sender, EventArgs e)
        {
            if (TextBoxPhone.Text == "Số Điện Thoại")
            {
                TextBoxPhone.Text = "";
                TextBoxPhone.ForeColor = Color.Black;
            }
        }

        private void TextBoxAddress_Leave(object sender, EventArgs e)
        {
            if (TextBoxAddress.Text == "")
            {
                TextBoxAddress.Text = "Địa Chỉ";
                TextBoxAddress.ForeColor = Color.Black;
            }
        }

        private void TextBoxAddress_Enter(object sender, EventArgs e)
        {
            if (TextBoxAddress.Text == "Địa Chỉ")
            {
                TextBoxAddress.Text = "";
                TextBoxAddress.ForeColor = Color.Black;
            }
        }

        private void textBoxCMND_Leave(object sender, EventArgs e)
        {
            if (textBoxCMND.Text == "")
            {
                textBoxCMND.Text = "CMND";
                textBoxCMND.ForeColor = Color.Black;
            }
        }

        private void textBoxCMND_Enter(object sender, EventArgs e)
        {
            if (textBoxCMND.Text == "CMND")
            {
                textBoxCMND.Text = "";
                textBoxCMND.ForeColor = Color.Black;
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "")
            {
                textBoxMail.Text = "Gmail";
                textBoxMail.ForeColor = Color.Black;
            }
        }

        private void textBoxMail_Enter(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "Gmail")
            {
                textBoxMail.Text = "";
                textBoxMail.ForeColor = Color.Black;
            }
        }
    }
}
