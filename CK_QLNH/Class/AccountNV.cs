using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_QLNH
{
    class AccountNV
    {
        DataBase db = new DataBase();
        public bool insertAccount(string Username, string Password, string fname, string lname)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhanVien (UserName, PassWord, TenNV, HoNV)" +
                " VALUES (@user, @pass, @ten, @Ho)", db.GetConnection);

            command.Parameters.Add("@user", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ho", SqlDbType.VarChar).Value = lname;
            //command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool deleteAccount(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NhanVien WHERE Id = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
