using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_QLNH
{
    class IDLamViec
    {
        DataBase myDb = new DataBase();
        public bool insertIDLamViec(int Id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ChiaCa (id)" +
                " VALUES (@id)", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;


            myDb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool insertStudent(int Id, string t2, string t3, string t4, string t5, string t6, string t7, string cn)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ChiaCa(Id, Thu2,Thu3,Thu4,Thu5,Thu6,Thu7,CN)" +
                "VALUES (@ID, @t2, @t3, @t4, @t5, @t6, @t7, @cn)", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.VarChar).Value = t2;
            command.Parameters.Add("@t3", SqlDbType.VarChar).Value = t3;
            command.Parameters.Add("@t4", SqlDbType.VarChar).Value = t4;
            command.Parameters.Add("@t5", SqlDbType.VarChar).Value = t5;
            command.Parameters.Add("@t6", SqlDbType.VarChar).Value = t6;
            command.Parameters.Add("@t7", SqlDbType.VarChar).Value = t7;
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = cn;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool insertTime(int Id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TimeLamViec(Id)" +
                "VALUES (@ID)", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateTimeStartCa1(int Id, DateTime Ts)
        {
            SqlCommand command = new SqlCommand("UPDATE TimeLamViec SET TimeStart1=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Ts;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateTimeStartCa2(int Id, DateTime Ts)
        {
            SqlCommand command = new SqlCommand("UPDATE TimeLamViec SET TimeStart2=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Ts;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateTimeStartCa3(int Id, DateTime Ts)
        {
            SqlCommand command = new SqlCommand("UPDATE TimeLamViec SET TimeStart3=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Ts;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateTimeEndCa1(int Id, DateTime Te)
        {
            SqlCommand command = new SqlCommand("UPDATE TimeLamViec SET TimeEnd1=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateTimeEndCa2(int Id, DateTime Te)
        {
            SqlCommand command = new SqlCommand("UPDATE TimeLamViec SET TimeEnd2=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateTimeEndCa3(int Id, DateTime Te)
        {
            SqlCommand command = new SqlCommand("UPDATE TimeLamViec SET TimeEnd3=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool insertLuong(int Id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LuongNV(Id)" +
                "VALUES (@ID)", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateLuongThu2(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LuongNV SET Luong2=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateLuongThu3(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LuongNV SET Luong3=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateLuongThu4(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LuongNV SET Luong4=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateLuongThu5(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LuongNV SET Luong5=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateLuongThu6(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LuongNV SET Luong6=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateLuongThu7(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LuongNV SET Luong7=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateLuongCN(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LuongNV SET LuongCN=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool updateTimeDayNew(int Id)
        {
            SqlCommand command = new SqlCommand("UPDATE TimeLamViec SET TimeStart1=null,TimeEnd1=null, TimeStart2=null,TimeEnd2=null, TimeStart3=null,TimeEnd3=null WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            //command.Parameters.Add("@t1", SqlDbType.DateTime).Value = null;
            //command.Parameters.Add("@e1", SqlDbType.DateTime).Value = null;
            //command.Parameters.Add("@t2", SqlDbType.DateTime).Value = null;
            //command.Parameters.Add("@e2", SqlDbType.DateTime).Value = null;
            //command.Parameters.Add("@t3", SqlDbType.DateTime).Value = null;
            //command.Parameters.Add("@e2", SqlDbType.DateTime).Value = null;

            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
       
    }
}
