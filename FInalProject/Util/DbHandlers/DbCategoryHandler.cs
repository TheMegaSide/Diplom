using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbCategoryHandler : IDbExecuteHandler<Category>
    {

        public Category GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Category
            {
                CategoryId = (int)(long)rdr["CategoryId"],
                CategoryName = rdr["CategoryName"].ToString()
                
            };
        }
    }
}