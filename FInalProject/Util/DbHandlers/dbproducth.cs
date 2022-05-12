using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class dbproducth : IDbExecuteHandler<Product>
    {
        public Product GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Product
            {
                CategoryId = (decimal) rdr["CategoryId"],
                SellerId = (decimal)rdr["SellerId"],
                StockId = (decimal)rdr["StockId"],
                ProductId = (decimal)rdr["ProductId"],
                ProductName =  rdr["ProductName"].ToString(),
                ProductIndex = rdr["ProductIndex"].ToString(),
                ProductUnit = rdr["ProductUnit"].ToString(),

                ProductPrice = (decimal)rdr["ProductPrice"],
                ProductDate = (DateTime)rdr["ProductDate"],
                Amount = (decimal)rdr["Amount"]
                
            };
        }
    }
}