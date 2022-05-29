using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class DbRaceHandler: IDbExecuteHandler<Race>
    
    {
        public Race GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Race
            {
                id = (int)rdr["id"],
                value = (double)rdr["cargoValue"],
                raceTime = (double)rdr["time"],
                driver = (int)rdr["driver"],
                auto = (int) rdr["auto"],
                autoGovnum = rdr["govnum"].ToString(),
                driverName = rdr["name"].ToString(),
                date = (DateTime)rdr["date"],
            };
        }
    }
}