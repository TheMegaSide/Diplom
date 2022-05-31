using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class DbDriverhandler : IDbExecuteHandler<Driver>
    {
        public Driver GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Driver
            {
                id = (int)rdr["id"],
                
                name = rdr["name"].ToString(),
                
                drcertnum = (int) rdr["drcertnum"],
                drcertdate = (DateTime)rdr["drcertdate"],
                classs = rdr["class"].ToString(),
                timedriving = rdr["timedriving"].ToString(),
                auto = (int)rdr["auto"]


            };
        }


    }
}
    
        

