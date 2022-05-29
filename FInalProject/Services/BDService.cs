using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using FInalProject.Models;
using FInalProject.Util.DB;
using FInalProject.Util.DbHandlers;

namespace FInalProject.Services
{
    public class BDService
    {
        public readonly string ConnectionString;

        public BDService(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("NpgsqlConnection");
        }

        public List<Car> GetCarsList()
        {
            string comText =
                "Select * from cars;";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Car>(ConnectionString, comText, new DbCarHandler());
        }

        public CarNew GetCarById(int id)
        {
            string comText =
                "Select * from public.\"CarList\" where  id=" + id;
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<CarNew>(ConnectionString, comText, new DBCarNewHandler())[0];
        }

        public void CarEdit(CarNew car)
        {
            string comText =
                "UPDATE public.\"CarList\" SET type="+"'"+car.type+"', model='"+car.model+"', vin='"+car.vin+"', yearprod="+car.yearprod+
                ", govnum='"+car.govnum+"', value="+car.value+", weight="+car.weight+", maxweight="+car.maxweight+", fueltype='"+car.fueltype+
                "', techstate='"+car.techstate+"', srokpodk='"+car.srokpodk.Date+"', inscomp='"+car.inscomp+"', osagocost="+car.osagocost+
                ", platondate='"+car.platondate.Date+"', platonreplace='"+car.platonreplace+"', glonastype='"+car.glonastype+"', simnum='"+car.simnum+
                "', glonasdate='"+car.glonasdate+"', worktype='"+car.worktype+"', ptsowner='"+car.ptsowner+"', stsowner='"+car.stsowner+"', regionloc='"+car.regionloc+"', platonnum='"+car.platonnum+"'"+
            "where id=" + car.id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbCarHandler());
        }

        

        public void DeleteCar(int id)
        {
            string comText =
                "delete from public.\"CarList\" where id=" + id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbCarHandler());
        }

        public List<CarNew> GetCarsByField(string key, string field)
        {
            string comText =
                "Select * from public.\"CarList\" where  " + field + "='" + key + "'";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<CarNew>(ConnectionString, comText, new DBCarNewHandler());
        }

        public List<Driver> GetDriversByField(string key, string field)
        {
            string comText =
                "Select * from drivers where  " + field + "='" + key + "'";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Driver>(ConnectionString, comText, new DbDriverhandler());
        }


        public List<Driver> GetDriverList()
        {
            string comText =
                "select *  from drivers";
            return DbExecutor.Execute<Driver>(ConnectionString, comText, new DbDriverhandler());
        }

        public Driver GetDriverById(int id)
        {
            string comText =
                "select *  from drivers where id=" + id;
            return DbExecutor.Execute<Driver>(ConnectionString, comText, new DbDriverhandler())[0];
        }

        public void DriverEdit(Driver driver)
        {
            string comText =
                "Update drivers set surname='" + driver.surname + "',name='" + driver.name +
                "',patronymic='" + driver.patronymic + "',drcertnum=" + driver.drcertnum + ",drcertdate='" +
                driver.drcertdate + "',class='" + driver.classs + "',timedriving=" + driver.timedriving +
                " where id=" + driver.id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbDriverhandler());
        }

        public void AddDriver(Driver driver)
        {
            string comText =
                "Insert into drivers(surname,name,patronymic,drcertnum,drcertdate,class,timedriving) values('" +
                driver.surname +
                "','" + driver.name + "','" + driver.patronymic + "'," + driver.drcertnum + ",'" + driver.drcertdate +
                "','" + driver.classs + "','" + driver.timedriving + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbDriverhandler());
        }

        public void DeleteDriver(Driver driver)
        {
            string comText =
                "delete from drivers where id=" + driver.id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbDriverhandler());
        }
        public List<Race> GetRaceList()
        {
            string comText =
                "select *  from races,drivers,cars where drivers.id=races.driver and cars.id=races.auto";
            return DbExecutor.Execute<Race>(ConnectionString, comText, new DbRaceHandler());
        }

        public void AddRace(Race race)
        {
            string comText =
                "Insert into races(\"cargoValue\",\"time\",driver,auto,date) values(" +
                race.value + "," + race.raceTime + "," + race.driver 
                + "," + race.auto + ",'" + race.date +"') ";
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbRaceHandler());
        }
        public Race GetRaceById(int id)
        {
            string comText =
                "select *  from races,drivers,cars where drivers.id=races.driver and cars.id=races.auto and races.id=" + id;
            return DbExecutor.Execute<Race>(ConnectionString, comText, new DbRaceHandler())[0];
        }
        public void DeleteRace(int id)
        {
            string comText =
                "delete from races where id=" + id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbRaceHandler());
        }
        public void RaceEdit(Race race)
        {
            string comText =
                "Update races set \"cargoValue\"="+
                race.value + ",\"time\"=" + race.raceTime + ",driver=" + race.driver 
                + ",auto=" + race.auto + ",date='" + race.date +"'";
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbDriverhandler());
        }
        public List<CarNew> GetCarsNewList()
        {
            string comText =
                "Select * from public.\"CarList\";";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<CarNew>(ConnectionString, comText, new DBCarNewHandler());
        }
        public void AddNewCar(CarNew car)
        {
            string comText =
                "Insert into public.\"CarList\"(type,model,vin,yearprod,govnum,value,weight,maxweight,fueltype,techstate,srokpodk,inscomp, osagocost,platonnum,platondate,platonreplace,glonastype,simnum,glonasdate, worktype, ptsowner,stsowner,regionloc)"+ 
                "values('"+ car.type + "','" + car.model + "','" + car.vin + "'," + car.yearprod + ",'" 
                + car.govnum + "',cast(" + car.value.ToString().Replace(',','.') + " as double precision)," + car.weight + "," + car.maxweight + ",'" 
                + car.fueltype + "','" + car.techstate +"','"+car.srokpodk.Date+"','"+car.inscomp+"',cast("
                +car.osagocost.ToString().Replace(',','.')+" as double precision),"+car.platonnum+",'"+car.platondate.Date+"','"+car.platonreplace+ "','"
                +car.glonastype+"','"+car.simnum+"','"+car.glonasdate.Date+"','"+car.worktype+"','"
                +car.ptsowner+"','"+car.stsowner+"','"+car.regionloc+"') ";
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DBCarNewHandler());
        }
        public List<TO> GetTOList(string month, string year)
        {
            string comText =
                "select * from \"to\",\"CarList\" where \"CarList\".id=\"to\".auto and extract(month from date)="+month+" and extract(year from date)="+year;
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<TO>(ConnectionString, comText, new DBTOHandler());
        }

        public void AddTO(TO to)
        {
            string comText = "INSERT INTO public.\"to\"(auto, totype, date) VALUES ("+to.auto+",'"+to.toType+"','"+to.date+"')";
            DbExecutor.Execute(ConnectionString, comText, new DBCarNewHandler());
        }
    }
}