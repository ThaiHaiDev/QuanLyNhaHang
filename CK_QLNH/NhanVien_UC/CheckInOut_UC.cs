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
    public partial class CheckInOut_UC : UserControl
    {
        public CheckInOut_UC()
        {
            InitializeComponent();
        }
        DataBase myDb = new DataBase();
        Login_Form login = new Login_Form();
        IDLamViec idl = new IDLamViec();
        public int CheckThu()       // Check Thứ Now để lấy cột của thứ Now để lấy ca ra và tính Time đúng của ca làm.
        {
            int cot = 0;
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "MonDay")
                cot = 1;
            if (thu == "Tuesday")
                cot = 2;
            if (thu == "Wednesday")
                cot = 3;
            if (thu == "Thursday")
                cot = 4;
            if (thu == "Friday")
                cot = 5;
            if (thu == "Saturday")
                cot = 6;
            if (thu == "Sunday")
                cot = 7;
            return cot;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int name = login.IDKey;
            SqlCommand command = new SqlCommand(" SELECT * FROM ChiaCa WHERE Id = '" + name + "'", myDb.GetConnection);
            SqlDataAdapter adapterc = new SqlDataAdapter(command);
            DataTable tablec = new DataTable();
            adapterc.Fill(tablec);
            string test = tablec.Rows[0][CheckThu()].ToString().Trim();   // Lấy số mã hóa ca ra, nếu số 1 là làm ca 2 và 3
            int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());
            if (test == "2" || test == "-2")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (HourInt >= 7 && HourInt <= 11)
                    {
                        idl.updateTimeStartCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }
                if (radioButtonTrua.Checked == true)
                    MessageBox.Show("Không Phải Ca Làm Của Bạn");
                if (radioButtonToi.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        idl.updateTimeStartCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca làm");
                }
            }
            if (test == "1" || test == "-1")
            {
                if (radioButtonSang.Checked == true)
                    MessageBox.Show("Không Phải Ca Làm Của Bạn");
                if (radioButtonTrua.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        idl.updateTimeStartCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }
                if (radioButtonToi.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        idl.updateTimeStartCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }
            }
            if (test == "3" || test == "-3")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (HourInt >= 7 && HourInt <= 11)
                    {
                        idl.updateTimeStartCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }

                if (radioButtonTrua.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        idl.updateTimeStartCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }
                if (radioButtonToi.Checked == true)
                {
                    MessageBox.Show("Không Phải Ca Làm Của Bạn");
                }
            }
            if (test == "0")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (HourInt >= 7 && HourInt <= 11)
                    {
                        idl.updateTimeStartCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }

                if (radioButtonTrua.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        idl.updateTimeStartCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }
                if (radioButtonToi.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        idl.updateTimeStartCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Bắt Đầu Tính Thời Gian Ca Làm", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Không Phải Thời Gian Bắt Đầu Ca Làm");
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            int name = login.IDKey;
            SqlCommand command = new SqlCommand(" SELECT * FROM ChiaCa WHERE Id = '" + name + "'", myDb.GetConnection);
            SqlDataAdapter adapterc = new SqlDataAdapter(command);
            DataTable tablec = new DataTable();
            adapterc.Fill(tablec);
            string test = tablec.Rows[0][CheckThu()].ToString().Trim();   // Lấy số mã hóa ca ra, nếu số 1 là làm ca 2 và 3
            int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());
            // Tạo Table check để kiểm tra đã có Time Start chưa, nếu chưa thì không thể Stop được
            SqlCommand commandcheck = new SqlCommand(" SELECT * FROM TimeLamViec WHERE Id = '" + name + "'", myDb.GetConnection);
            SqlDataAdapter adaptercheck = new SqlDataAdapter(commandcheck);
            DataTable tablecheck = new DataTable();
            adaptercheck.Fill(tablecheck);
            if (test == "2" || test == "-2")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart1"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 7 && HourInt <= 11)
                        {
                            idl.updateTimeEndCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
                if (radioButtonTrua.Checked == true)
                    MessageBox.Show("Không Phải Ca Làm Của Bạn");
                if (radioButtonToi.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart3"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 18 && HourInt < 22)
                        {
                            idl.updateTimeEndCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
            }
            if (test == "1" || test == "-1")
            {
                if (radioButtonSang.Checked == true)
                    MessageBox.Show("Không Phải Ca Làm Của Bạn");
                if (radioButtonTrua.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart2"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 11 && HourInt < 15)
                        {
                            idl.updateTimeEndCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
                if (radioButtonToi.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart3"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 18 && HourInt < 22)
                        {
                            idl.updateTimeEndCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
            }
            if (test == "3" || test == "-3")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart1"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 7 && HourInt <= 11)
                        {
                            idl.updateTimeEndCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
                if (radioButtonTrua.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart2"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 11 && HourInt < 15)
                        {
                            idl.updateTimeEndCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
                if (radioButtonToi.Checked == true)
                {
                    MessageBox.Show("Không Phải Ca Làm Của Bạn");
                }
            }
            if (test == "0")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart1"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 7 && HourInt <= 11)
                        {
                            idl.updateTimeEndCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
                if (radioButtonTrua.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart2"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 11 && HourInt < 15)
                        {
                            idl.updateTimeEndCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
                if (radioButtonToi.Checked == true)
                {
                    if (tablecheck.Rows[0]["TimeStart3"].ToString().Trim() == "")
                    {
                        MessageBox.Show("Error", "Bạn Chưa Start Nên Không Thể Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (HourInt >= 18 && HourInt < 22)
                        {
                            idl.updateTimeEndCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stop Tính Thời Gian Ca Làm", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không Phải Thời Gian Kết Thúc Ca Làm");
                    }
                }
            }
        }
    }
}
