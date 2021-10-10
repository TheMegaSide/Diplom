using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbCategoryHandler : IDbExecuteHandler<Category>
    {
        public Category GetDataAfterExecute(OracleDataReader rdr)
        {
            return new Category
            {
                CategoryId = (int)(long)rdr["CategoryId"],
                CategoryName = rdr["CategoryName"].ToString()
                
            };
        }
    }
}