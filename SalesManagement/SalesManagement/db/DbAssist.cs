using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SalesManagement
{

    class DbAssist
    {
        static SQLiteConnection    m_dbConnection = null;
        static int m_dbError = 0;  

        static public string getDatabaseFilePath()
        {
            string w_dbName = "sales.db3";
            string w_dbPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "db", w_dbName);
            return w_dbPath;
        }

        static public string getConnectionString()
        {
            string w_conString = "";

            string w_dbPath = getDatabaseFilePath();
            w_conString = string.Format("Data Source={0};Version=3;", w_dbPath);

            return w_conString;
        }

        static public bool connectToDb()
        {
            bool w_ret = false;

            if ( !File.Exists(getDatabaseFilePath()) )
            {
                return false;
            }

            try
            {
                m_dbConnection = new SQLiteConnection(getConnectionString());
                m_dbConnection.Open();
                w_ret = true;
            }
            catch (SQLiteException ex)
            {
                m_dbError = ex.ErrorCode;
                Console.WriteLine("Error in connectToDB : {0}", ex.Message);
                m_dbConnection = null;
                w_ret = false;
            }
            catch (Exception ex)
            {
                m_dbError = -100;
                Console.WriteLine("Error in connectToDB : {0}", ex.Message);
                m_dbConnection = null;
                w_ret = false;
            }
            return w_ret;
        }

        static public void closeDb()
        {
            if (m_dbConnection != null)
            {
                m_dbConnection.Close();
                m_dbConnection = null;
            }
        }

        static public bool executeCommand(string commandQuery)
        {
            bool w_ret = false;

            if (m_dbConnection == null)
                return false;

            try
            {
                m_dbError = 0;
                SQLiteCommand w_command = new SQLiteCommand(commandQuery, m_dbConnection);
                int w_rows = w_command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                m_dbError = ex.ErrorCode;
                Console.WriteLine("Error in connectToDB : {0}", ex.Message);
                m_dbConnection = null;
                w_ret = false;
            }
            return w_ret;
        }

        static public SQLiteDataReader executeQuery(string readQuery)
        {
            SQLiteDataReader w_reader = null;

            if (m_dbConnection == null)
                return w_reader;

            try
            {
                m_dbError = 0;
                SQLiteCommand w_command = new SQLiteCommand(readQuery, m_dbConnection);
                w_reader = w_command.ExecuteReader();
            }
            catch (SQLiteException ex)
            {
                m_dbError = ex.ErrorCode;
                Console.WriteLine("Error in connectToDB : {0}", ex.Message);
                m_dbConnection = null;
                w_reader = null;
            }
            return w_reader;
        }

        static public int GetErrorCode()
        {
            return m_dbError;
        }

    }
}
