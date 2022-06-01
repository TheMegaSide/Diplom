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
            DbExecutor.Execute(ConnectionString, comText, new DBCarNewHandler());
        }

        

        public void DeleteCar(int id)
        {
            string comText =
                "delete from public.\"CarList\" where id=" + id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DBCarNewHandler());
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
            string comText="";
            if (field == "name")
            {
                comText =
                    "Select * from drivers where  name~'"+key+"'";
                Console.WriteLine($"INFO:{comText}");
            }
            else
            {
                comText =
                    "Select * from drivers where  " + field + "='" + key + "'";
                Console.WriteLine($"INFO:{comText}");
            }

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
                "Update drivers set name='" + driver.name +
                 "',drcertnum=" + driver.drcertnum + ",drcertdate='" +
                driver.drcertdate + "',class='" + driver.classs + "',timedriving=" + driver.timedriving +" ,auto="+driver.auto+
                " where id=" + driver.id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbDriverhandler());
        }

        public void AddDriver(Driver driver)
        {
            string comText =
                "Insert into drivers(name,drcertnum,drcertdate,class,timedriving, auto) values('" +
                 driver.name + "',"  + driver.drcertnum + ",'" + driver.drcertdate.Date +
                "','" + driver.classs + "','" + driver.timedriving + "',"+driver.auto+") ";

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
                "select *  from races,drivers,\"CarList\" where drivers.id=races.driver and \"CarList\".id=races.auto";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Race>(ConnectionString, comText, new DbRaceHandler());
        }
        public List<Race> GetRaceByDate(DateTime startdate, DateTime enddate)
        {
            Console.WriteLine(startdate);
            string comText = "";
            if (enddate.ToString() == "01.01.0001 0:00:00")
            {
                comText =
                    "select *  from races,drivers,\"CarList\" where date>'"+startdate.ToShortDateString()+"' and drivers.id=races.driver and \"CarList\".id=drivers.auto";
            }
            else
            {
                comText =
                    "select *  from races,drivers,\"CarList\" where date>'"+startdate.Date +"' and date<'"+enddate.Date+"'";
            }
            Console.WriteLine($"INFO:{comText}");
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
                "select *  from races,drivers,\"CarList\" where drivers.id=races.driver and \"CarList\".id=races.auto and races.id=" + id;
            return DbExecutor.Execute<Race>(ConnectionString, comText, new DbRaceHandler())[0];
        }
        public void DeleteRace(int id)
        {
            string comText =
                "delete from races where id=" + id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbRaceHandler());
        }
        public void DeleteTO(int id)
        {
            string comText =
                "delete from \"to\" where id=" + id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DBTOHandler());
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
        public void EditTO(TO to)
        {
            string comText = "UPDATE public.\"to\" SET auto="+to.auto+", totype="+to.toType+", date="+to.date+", state="+to.state+
            "WHERE id="+to.id;
            DbExecutor.Execute(ConnectionString, comText, new DBTOHandler());
        }

        public TO GetToById(int id)
        {
            string comText =
                "select * from \"to\",\"CarList\" where \"CarList\".id=\"to\".auto and \"to\".id="+id;
            return DbExecutor.Execute<TO>(ConnectionString, comText, new DBTOHandler())[0];
        }

        public void TOCompleted(int id, DateTime date, int auto, string toType)
        {
            string comText = "UPDATE public.\"to\" SET  state='Выполнено'"+
                             "WHERE id="+id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DBTOHandler());
            DateTime newToDate = new DateTime();
            if (toType == "ТО-1")
            {
                newToDate = date.AddDays(20);
            }

            if (toType == "ТО-2")
            {
                newToDate = date.AddDays(100);
            }

            comText = "INSERT INTO public.\"to\"(auto, totype, date, state)VALUES ("+auto+",'"+toType+"','"+newToDate+"','Запланировано' )";
            DbExecutor.Execute(ConnectionString, comText, new DBTOHandler());
        }
        public List<DTP> GetDTPList()
        {
            string comText =
                "Select dtp.*,\"CarList\".govnum,drivers.name from dtp,\"CarList\",drivers where dtp.auto=\"CarList\".id and drivers.id=dtp.driver";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<DTP>(ConnectionString, comText, new DBDTPHandler());
        }
        
    }
}