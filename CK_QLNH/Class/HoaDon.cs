using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_QLNH
{
    class HoaDon
    {
        DataBase db = new DataBase();

        // create a function to insert BanAn
        public bool insertHoaDon(string idban, string tenmonhd, int soluong, float giathanh, DateTime thoigian)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO HoaDon (idban, tenmonhd, soluong, giathanh, thoigian) " +
                " VALUES (@idb, @tenmhd, @sl, @gia, @tg) ", db.GetConnection);


            command.Parameters.Add("@idb", SqlDbType.VarChar).Value = idban;
            command.Parameters.Add("@tenmhd", SqlDbType.VarChar).Value = tenmonhd;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giathanh;
            command.Parameters.Add("@tg", SqlDbType.DateTime).Value = thoigian;


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

        // check id hoa don gọi món tiếp tục
        public bool checkTenIDHD(string idhd)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HoaDon WHERE Id <> @idhd", db.GetConnection);
            //command.Parameters.Add("@idb", SqlDbType.VarChar).Value = IdBan;
            command.Parameters.Add("@idhd", SqlDbType.VarChar).Value = idhd;
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


        // check id ban dat lai
        public bool checkTenIDBan(string IdBan)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HoaDon WHERE idban<>@idb", db.GetConnection);
            command.Parameters.Add("@idb", SqlDbType.VarChar).Value = IdBan;
            //command.Parameters.Add("@idhd", SqlDbType.VarChar).Value = idhd;
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

        
        public bool deleteMonAn(string tenm)
        {
            SqlCommand command = new SqlCommand("DELETE FROM HoaDon WHERE tenmonhd=@tenm", db.GetConnection);
            command.Parameters.Add("tenm", SqlDbType.VarChar).Value = tenm;
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

        public bool deleteHoaDon(string idban)
        {
            SqlCommand command = new SqlCommand("DELETE FROM HoaDon WHERE idban=@idb", db.GetConnection);
            command.Parameters.Add("idb", SqlDbType.VarChar).Value = idban;
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

        public bool updateHoaDon(string tenmonhd, int soluong, float giathanh, DateTime thoigian)
        {
            SqlCommand command = new SqlCommand(" UPDATE HoaDon SET soluong=@sl, giathanh=@gia, thoigian=@tg WHERE tenmonhd=@tenmhd", db.GetConnection);


            command.Parameters.Add("@tenmhd", SqlDbType.VarChar).Value = tenmonhd;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giathanh;
            command.Parameters.Add("@tg", SqlDbType.DateTime).Value = thoigian;

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

        public DataTable getHoaDon(SqlCommand command)
        {
            command.Connection = db.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
