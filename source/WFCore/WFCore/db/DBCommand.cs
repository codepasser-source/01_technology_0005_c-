using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using WFCore.exception;
namespace WFCore.db
{
    public class DBCommand
    {
        private const string POWER_MODE_SQL_QUERY_ALL = "SELECT seq,startDateTime,endDateTime,status FROM T_PowerMode";
        private const string POWER_MODE_SQL_DELETE_BY_SEQ = "DELETE FROM T_PowerMode WHERE seq = :a";

        public DataTable query()
        {
            DataTable dataTable = null;
            SQLiteConnection sqliteConn = null;
            try
            {
                sqliteConn = DBConnectionManager.connection();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(DBCommand.POWER_MODE_SQL_QUERY_ALL, sqliteConn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables.Count > 0)
                {
                    dataTable = dataSet.Tables[0];
                }

            }
            catch (CoreException ex)
            {
                throw ex;
            }
            catch (TypeInitializationException ex)
            {
                throw new CoreException(CoreException.FAILED_TO_GET_DB_CONNECTION_0, string.Empty);
            }
            catch (SQLiteException ex)
            {
                throw new CoreException(CoreException.FAILED_TO_EXECUTE_SQL_1, DBCommand.POWER_MODE_SQL_QUERY_ALL);
            }
            finally
            {
                DBConnectionManager.closeConnection(sqliteConn);
            }
            return dataTable;
        }

        public void deleteBySeq(string seq)
        {
            SQLiteConnection sqliteConn = null;
            try
            {

                sqliteConn = DBConnectionManager.connection();
                SQLiteTransaction tran = sqliteConn.BeginTransaction();

                SQLiteCommand sqlCommand = new SQLiteCommand(DBCommand.POWER_MODE_SQL_DELETE_BY_SEQ, sqliteConn);
                sqlCommand.Parameters.Add(new SQLiteParameter("a", DbType.Int32));
                sqlCommand.Parameters[0].Value = seq;
                sqlCommand.ExecuteNonQuery();
                tran.Commit();
            }
            catch (CoreException ex)
            {
                throw ex;
            }
            catch (TypeInitializationException ex)
            {
                throw new CoreException(CoreException.FAILED_TO_GET_DB_CONNECTION_0, string.Empty);
            }
            catch (SQLiteException ex)
            {
                throw new CoreException(CoreException.FAILED_TO_EXECUTE_SQL_1, DBCommand.POWER_MODE_SQL_DELETE_BY_SEQ);
            }
            finally
            {
                DBConnectionManager.closeConnection(sqliteConn);
            }
        }
    }


}
