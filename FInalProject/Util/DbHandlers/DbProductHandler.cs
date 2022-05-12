using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbProductHandler : IDbExecuteHandler<Product>
    {
        public Product GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Product
            {
                ProductId = (decimal)rdr["ProductId"],
                ProductName =  rdr["ProductName"].ToString(),
                ProductIndex = rdr["ProductIndex"].ToString(),
                ProductUnit = rdr["ProductUnit"].ToString(),
                
                CategoryName = rdr["CategoryName"].ToString(),
                SellerName = rdr["SellerName"].ToString(),
                StockAdress = rdr["StockAdress"].ToString(),
                ProductPrice = (decimal)rdr["ProductPrice"],
                ProductDate = (DateTime)rdr["ProductDate"],
                Amount = (decimal)rdr["Amount"]
                
            };
        }
    }
}