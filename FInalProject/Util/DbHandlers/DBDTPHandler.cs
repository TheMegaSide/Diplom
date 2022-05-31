using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class DBDTPHandler : IDbExecuteHandler<DTP>
    {
        public DTP GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new DTP
            {
                id = (int) rdr["id"],
                driver = (int) rdr["driver"],
                auto = (int) rdr["auto"],
                drivername = rdr["name"].ToString(),
                autodata = rdr["govnum"].ToString(),
                conditions = rdr["conditions"].ToString(),
                victimsdata = rdr["victimsdata"].ToString(),
                damagedtransport = (int) rdr["damagedtransport"],
                driverfault = rdr["driverfault"].ToString(),
                date = (DateTime) rdr["date"],
                region = rdr["region"].ToString(),
                dtpcodintions = rdr["drpcoditions"].ToString(),
                dtpreasons = rdr["dtpreasons"].ToString(),
                died = (int) rdr["died"],
                traumas = (int) rdr["traumas"],
                oform = rdr["oform"].ToString(),
                addtitions = rdr["additions"].ToString()


            };
        }
    }
}
        
    
