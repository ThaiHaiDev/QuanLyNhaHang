using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_QLNH
{
    class CaLam
    {
        DataBase myDb = new DataBase();
        public bool updateLamHo2(int Id, int Thu2)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET Thu2=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
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
        public bool updateLamHo3(int Id, int Thu2)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET Thu3=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
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
        public bool updateLamHo4(int Id, int Thu2)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET Thu4=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
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
        public bool updateLamHo5(int Id, int Thu2)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET Thu5=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
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
        public bool updateLamHo6(int Id, int Thu2)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET Thu6=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
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
        public bool updateLamHo7(int Id, int Thu2)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET Thu7=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
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
        public bool updateLamHoCN(int Id, int Thu2)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET CN=@t2 WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
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
