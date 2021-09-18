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
    public partial class KiemTraSLForm : Form
    {
        public KiemTraSLForm()
        {
            InitializeComponent();
        }
        HoaDon hoadon = new HoaDon();
        private void KiemTraSLForm_Load(object sender, EventArgs e)
        {
            //lay thong tin tenmon
            comboBoxTenMon.DataSource = hoadon.getHoaDon(new SqlCommand("SELECT * FROM QLMonAn"));
            comboBoxTenMon.DisplayMember = "tenmon";
            comboBoxTenMon.ValueMember = "Id";

        }

        private void comboBoxTenMon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTenMon.Text.Trim() == "Chao Yen")
            {
                labelCongThuc.Text = "Mỗi Phần Chao Yen Được Làm Từ: 10g Thịt, 20g Tinh Bột, 5g Rau";
            }
            else if (comboBoxTenMon.Text.Trim() == "Ga Chien Bot")
            {
                labelCongThuc.Text = "Mỗi Phần Ga Chien Bot Được Làm Từ: 30g Thịt, 50g Tinh Bột, 5g Rau";
            }
            else if (comboBoxTenMon.Text.Trim() == "Vit Nau Mang")
            {
                labelCongThuc.Text = "Mỗi Phần Vit Nau Mang Được Làm Từ: 20g Thịt, 10g Tinh Bột, 15g Rau";
            }
            else
            {
                labelCongThuc.Text = "Mỗi Phần " + comboBoxTenMon.Text.Trim() + " Được Làm Từ: 15g Thịt, 15g Tinh Bột, 10g Rau";
            }
        }
        public int TimMin(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }
        private void buttonKtraSL_Click(object sender, EventArgs e)
        {
            if (textBoxTinhBot.Text == "" || textBoxThit.Text == "" || textBoxRau.Text == "")
            {
                MessageBox.Show("Không Thể Để Trống Dữ Liệu Input Kiểm Tra");
            }
            else if (textBoxRau.Text != "" && textBoxThit.Text != "" && textBoxRau.Text != "")
            {
                if (comboBoxTenMon.Text.Trim() == "Chao Yen")
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 5 || Convert.ToInt32(textBoxTinhBot.Text) < 20 || Convert.ToInt32(textBoxThit.Text) < 10)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 5 && Convert.ToInt32(textBoxTinhBot.Text) >= 20 && Convert.ToInt32(textBoxThit.Text) >= 10)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 5;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 20;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 10;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + comboBoxTenMon.Text.Trim();

                    }
                }
                else if (comboBoxTenMon.Text.Trim() == "Ga Chien Bot")
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 5 || Convert.ToInt32(textBoxTinhBot.Text) < 50 || Convert.ToInt32(textBoxThit.Text) < 30)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 5 || Convert.ToInt32(textBoxTinhBot.Text) >= 50 || Convert.ToInt32(textBoxThit.Text) >= 30)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 5;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 50;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 30;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + comboBoxTenMon.Text.Trim();

                    }
                }
                else if (comboBoxTenMon.Text.Trim() == "Vit Nau Mang")
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 15 || Convert.ToInt32(textBoxTinhBot.Text) < 10 || Convert.ToInt32(textBoxThit.Text) < 20)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 15 || Convert.ToInt32(textBoxTinhBot.Text) >= 10 || Convert.ToInt32(textBoxThit.Text) >= 20)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 15;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 10;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 20;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + comboBoxTenMon.Text.Trim();

                    }
                }
                else
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 10 || Convert.ToInt32(textBoxTinhBot.Text) < 15 || Convert.ToInt32(textBoxThit.Text) < 15)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 10 || Convert.ToInt32(textBoxTinhBot.Text) >= 15 || Convert.ToInt32(textBoxThit.Text) >= 15)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 10;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 15;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 15;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + comboBoxTenMon.Text.Trim();

                    }
                }
            }
        }
    }
}
