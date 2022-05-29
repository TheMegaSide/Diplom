using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class DBNextTOHandler: IDbExecuteHandler<TO>
    
    {
        public TO GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new TO
            {
                
                
                
                date = (DateTime)rdr["Max"]
            };
        }
    }
    
}