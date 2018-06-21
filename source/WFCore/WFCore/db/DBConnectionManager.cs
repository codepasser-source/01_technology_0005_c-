
using System.IO;
using System.Data.SQLite;
using WFCore.util;
using WFCore.exception;
using System.Data;

namespace WFCore.db
{

    public class DBConnectionManager
    {
        private static string DB_CONFIG_FILE = "\\DB.properties";
        private static string KEY_DB_FILE_PATH = "db_file_path";
        private static string connection_path = string.Empty;

        static DBConnectionManager()
        {
            string registerPath = System.Environment.CurrentDirectory + DB_CONFIG_FILE;
            try
            {
                if (!File.Exists(registerPath))
                {
                    throw new CoreException(CoreException.ERROR_FILE_NOT_EXIST_1, registerPath);
                }

                PropertyFileOperator file = new PropertyFileOperator(registerPath);
                connection_path = file.GetPropertiesText(KEY_DB_FILE_PATH);

                if (!File.Exists(connection_path))
                {
                    throw new CoreException(CoreException.ERROR_FILE_NOT_EXIST_1, connection_path);
                }

            }
            catch (CoreException e)
            {
                throw e;
            }
        }

        public static SQLiteConnection connection()
        {
            SQLiteConnection conn = null;

            try
            {
                conn = new SQLiteConnection("Data Source=" + connection_path);
                conn.Open();
            }
            catch (SQLiteException e)
            {
                
                throw new CoreException(CoreException.FAILED_TO_GET_DB_CONNECTION_0, string.Empty);
            }
            return conn;
        }

        public static void closeConnection(SQLiteConnection conn)
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }

}
