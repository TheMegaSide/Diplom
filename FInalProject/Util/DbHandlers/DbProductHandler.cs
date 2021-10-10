using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbProductHandler : IDbExecuteHandler<Product>
    {
        public Product GetDataAfterExecute(OracleDataReader rdr)
        {
            return new Product
            {
                ProductName =  rdr["ProductName"].ToString(),
                ProductIndex = rdr["ProductIndex"].ToString(),
                ProductUnit = rdr["ProductUnit"].ToString(),
                CategoryId = (decimal) rdr["CategoryId"],
                SellerId = (decimal)rdr["SellerId"],
                StockId = (decimal)rdr["StockId"],
                ProductPrice = (decimal)rdr["ProductPrice"],
                ProductDate = (DateTime)rdr["ProductDate"],
                Amount = (decimal)rdr["Amount"]
                
            };
        }
    }
}