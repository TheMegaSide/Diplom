using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class DBTypeHandler: IDbExecuteHandler<Type>
    
    {
        public Type GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Type
            {
                id = (int)rdr["id"],
                type = rdr["type"].ToString()
            };
        }
    }
   
}