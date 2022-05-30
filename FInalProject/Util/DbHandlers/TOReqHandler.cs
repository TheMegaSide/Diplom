using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class TOReqHandler: IDbExecuteHandler<TO>
    
    {
        public TO GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new TO
            {
               
                toType = rdr["totype"].ToString(),
                date = (DateTime)rdr["max"]
                
            };
        }
    }
    
}