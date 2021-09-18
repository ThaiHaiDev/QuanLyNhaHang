using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_QLNH
{
    class MONAN
    {
        DataBase db = new DataBase();


        // create a function to insert BanAn
        public bool insertMonAn(string Id, string tenmon, float giaban, string nguyenlieu, int soluong)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO QLMonAn (Id, tenmon, giamon, nguyenlieu, soluong) " +
                " VALUES (@id, @tenm, @gia, @nl, @sl) ", db.GetConnection);

            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@tenm", SqlDbType.VarChar).Value = tenmon;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giaban;
            command.Parameters.Add("@nl", SqlDbType.VarChar).Value = nguyenlieu;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        // check name
        public bool checkTenMonAn(string tenmon, int Id = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM QLMonAn WHERE tenmon = @tenm AND Id = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@tenm", SqlDbType.VarChar).Value = tenmon;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public bool deleteMonAn(string tenmon)
        {
            SqlCommand command = new SqlCommand("DELETE FROM QLMonAn WHERE tenmon=@tenm", db.GetConnection);
            command.Parameters.Add("tenm", SqlDbType.VarChar).Value = tenmon;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool updateMonAn(string tenmon, float giaban, string nguyenlieu, int soluong)
        {
            SqlCommand command = new SqlCommand(" UPDATE QLMonAn SET giamon=@gia, nguyenlieu=@nl, soluong=@sl  WHERE tenmon= @tenm", db.GetConnection);

            command.Parameters.Add("@tenm", SqlDbType.VarChar).Value = tenmon;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giaban;
            command.Parameters.Add("@nl", SqlDbType.VarChar).Value = nguyenlieu;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public bool updateSLMonAn(string tenmon, int soluong)
        {
            SqlCommand command = new SqlCommand(" UPDATE QLMonAn SET soluong=@sl  WHERE tenmon= '" + tenmon + "'", db.GetConnection);

            command.Parameters.Add("@tenm", SqlDbType.VarChar).Value = tenmon;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public DataTable getMonAn(SqlCommand command)
        {
            command.Connection = db.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertMonAnTop(string tenmon, int soluong)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO MonTop (MonTop,SoLuong) " +
               " VALUES (@tenm,@sl) ", db.GetConnection);


            command.Parameters.Add("@tenm", SqlDbType.VarChar).Value = tenmon;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
