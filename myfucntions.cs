using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace projecttest
{
    class myfunctions
    {
        private static SqlConnection DbConn = new SqlConnection();
        private static SqlDataAdapter DbAdapter = new SqlDataAdapter();
        private static SqlCommand DbCommand = new SqlCommand();
        private static SqlDataReader DbReader;

        public SqlTransaction DbTran;

        private static string strConnString = "Server=tcp:arsalazeemdatabase.database.windows.net,1433;Initial Catalog=fir_system;Persist Security Info=False;User ID=arsalazeem;Password=Arsal@123#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public void createConn()
        {
            try
            {
                if (DbConn.State != ConnectionState.Open)
                {
                    DbConn.ConnectionString = strConnString;
                    DbConn.Open();
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void beginTrans()
        {
            try
            {
                if (DbTran == null)
                {
                    if (DbConn.State == 0)
                    {
                        createConn();
                        DbTran = DbConn.BeginTransaction();
                        DbAdapter.SelectCommand.Transaction = DbTran;
                    }
                    else
                    {
                        DbTran = DbConn.BeginTransaction();
                        DbAdapter.SelectCommand.Transaction = DbTran;
                    }
                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public void commitTrans()
        {
            try
            {
                if (DbTran != null)
                {
                    DbTran.Commit();
                    DbTran = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void rollbackTrans()
        {
            try
            {
                if (DbTran != null)
                {
                    DbTran.Rollback();
                    DbTran = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (DbConn.State == ConnectionState.Closed)
                {
                    createConn();
                }

                DbCommand.Parameters.Clear();
                DbCommand.Connection = DbConn;
                DbCommand.CommandText = query;
                DbCommand.CommandType = CommandType.Text;
                DbCommand.CommandTimeout = 0;
                DbAdapter = new SqlDataAdapter(DbCommand);

                DbAdapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader readDatathroughReader(string query)
        {
            SqlDataReader reader;
            try
            {
                if (DbConn.State == ConnectionState.Closed)
                {
                    createConn();
                }

                DbCommand.Parameters.Clear();
                DbCommand.Connection = DbConn;
                DbCommand.CommandText = query;
                DbCommand.CommandType = CommandType.Text;
                DbCommand.CommandTimeout = 0;
                reader = DbCommand.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (DbConn.State == 0)
                {
                    createConn();
                }
                dbCommand.Connection = DbConn;
                dbCommand.CommandType = CommandType.Text;
                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int executeStoredProcedure(string spName, SqlCommand DbCommand)
        {
            try
            {
                if (DbConn.State == 0)
                {
                    createConn();
                }
                //DbCommand.Parameters.Clear();
                DbCommand.Connection = DbConn;
                DbCommand.CommandText = spName;
                DbCommand.CommandType = CommandType.StoredProcedure;
                return DbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (DbConn.State == 0)
                {
                    createConn();
                }
                DbAdapter.SelectCommand.CommandText = strSelectSql;
                DbAdapter.SelectCommand.CommandType = CommandType.Text;
                SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(DbAdapter);
                DbCommandBuilder.ConflictOption = ConflictOption.OverwriteChanges;
                //DbCommandBuilder.RefreshSchema();

                return DbAdapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}