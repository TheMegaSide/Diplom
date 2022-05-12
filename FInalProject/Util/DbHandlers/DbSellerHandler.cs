using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbSellerHandler : IDbExecuteHandler<Seller>
    {
        public Seller GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Seller
            {
                SellerId =  (int)(long)rdr["SellerId"],
                SellerName =  rdr["SellerName"].ToString(),
                SellerPhone = rdr["SellerPhone"].ToString(),
                SellerAddress = rdr["SellerAdress"].ToString()
               
                
            };
        }
    }
}