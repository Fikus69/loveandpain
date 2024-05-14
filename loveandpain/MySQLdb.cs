using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace loveandpain
{
    class MySQLdb
    {
        MySqlConnection mySqlConnection;

        private MySQLdb()
        {
            MySqlConnectionStringBuilder stringBuilder = new();
            stringBuilder.UserID = "root";
            stringBuilder.Password = "LoveAndHeart";
            stringBuilder.Database = "kursovaya";
            stringBuilder.Server = "127.0.0.1";
            stringBuilder.CharacterSet = "utf8mb4";
            //MySqlConnection = new MySqlConnection("server=192.168.200.13;user=student;password=student;database=drinks_1125;Character Set=utf8mb4");
            mySqlConnection = new MySqlConnection(stringBuilder.ToString());
            OpenConnection();
        }

        private bool OpenConnection()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal MySqlConnection GetConnection()
        {
            if (mySqlConnection.State != System.Data.ConnectionState.Open)
                if (!OpenConnection())
                    return null;

            return mySqlConnection;
        }

        static MySQLdb instance;
        public static MySQLdb Instance
        {
            get
            {
                if (instance == null)
                    instance = new MySQLdb();
                return instance;
            }
        }
    }
}
