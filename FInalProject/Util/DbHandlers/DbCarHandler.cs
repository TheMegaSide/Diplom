using FInalProject.Models;
using FInalProject.Util.DB;
using Npgsql;


namespace FInalProject.Util.DbHandlers
{
    public class DbCarHandler : IDbExecuteHandler<Car>
    {
        public Car GetDataAfterExecute(NpgsqlDataReader rdr)
        {
            return new Car
            {
                govnum = rdr["govnum"].ToString(),
                creater = rdr["creator"].ToString(),
                type = rdr["type"].ToString(),
                model = rdr["model"].ToString(),
                valueOfCar = (double)rdr["carvalue"],
                fuelType = rdr["fueltype"].ToString(),
                valueOfTank = (double)rdr["tankvalue"],
                glonasNum = (int)rdr["glonasnum"],
                platonNum = (int)rdr["platonnum"],
                owner = rdr["owner"].ToString(),
                location = rdr["location"].ToString(),
                runned = (double)rdr["runned"]
                
                
            };
        }


    }
}