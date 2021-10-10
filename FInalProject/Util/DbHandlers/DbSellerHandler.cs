using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbSellerHandler : IDbExecuteHandler<Seller>
    {
        public Seller GetDataAfterExecute(OracleDataReader rdr)
        {
            return new Seller
            {
                SellerName =  rdr["SellerName"].ToString(),
                SellerPhone = rdr["SellerPhone"].ToString(),
                SellerAddress = rdr["SellerAdress"].ToString()
               
                
            };
        }
    }
}