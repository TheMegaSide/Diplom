using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class DBTOHandler: IDbExecuteHandler<TO>
    
    {
        public TO GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new TO
            {
                id = (int)rdr["id"],
                
                auto = (int) rdr["auto"],
                toType = rdr["totype"].ToString(),
                date = (DateTime)rdr["date"],
                autoType = rdr["type"].ToString(),
                yearProd = (int)rdr["yearprod"],
                model = rdr["model"].ToString(),
                govnum = rdr["govnum"].ToString(),
                state = rdr["state"].ToString()
            };
        }
    }
    
}