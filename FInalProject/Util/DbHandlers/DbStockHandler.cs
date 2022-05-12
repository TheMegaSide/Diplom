using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbStockHandler: IDbExecuteHandler<Stock>
    {
        public Stock GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Stock
            {
                StockId =  (int)(long)rdr["StockId"],
                StockAddress = rdr["StockAdress"].ToString()
               
                
            };
        }
    }
   
}