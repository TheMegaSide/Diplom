using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;

namespace FInalProject.Util.DbHandlers
{
    public class DBCarNewHandler : IDbExecuteHandler<CarNew>
    {
        public CarNew GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new CarNew()
            {
                id =(int)rdr["id"],
                type = rdr["type"].ToString(),
                model = rdr["model"].ToString(),
                vin = rdr["vin"].ToString(),
                yearprod = (int)rdr["yearprod"],
                govnum = rdr["govnum"].ToString(),
                value = (double)rdr["value"],
                weight = (int)rdr["weight"],
                maxweight = (int)rdr["maxweight"],
                fueltype = rdr["fueltype"].ToString(),
                techstate = rdr["techstate"].ToString(),
                srokpodk = (DateTime)rdr["srokpodk"],
                inscomp = rdr["inscomp"].ToString(),
                osagocost = (double)rdr["osagocost"],
                platonnum = rdr["platonnum"].ToString(),
                platondate = (DateTime)rdr["platondate"],
                platonreplace = rdr["platonreplace"].ToString(),
                glonastype = rdr["glonastype"].ToString(),
                simnum = rdr["simnum"].ToString(),
                glonasdate = (DateTime)rdr["glonasdate"],
                worktype = rdr["worktype"].ToString(),
                ptsowner = rdr["ptsowner"].ToString(),
                stsowner = rdr["stsowner"].ToString(),
                regionloc = rdr["regionloc"].ToString()
                
                
            };
        }
    }
}