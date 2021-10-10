using System.Collections.Generic;
using FInalProject.Util.DbHandlers;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DB
{
    public class DbExecutor
    {
        public static List<T> Execute<T>(string connectionString, string query, IDbExecuteHandler<T> executeHandlerHandler)
        {
            var returnObject = new List<T>();
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        T item = executeHandlerHandler.GetDataAfterExecute(rdr);
                        returnObject.Add(item);
                    }
                }
            }

            return returnObject;
        }
    }
}