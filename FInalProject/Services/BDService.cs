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

        public Car GetCarById(int id)
        {
            string comText =
                "Select * from cars where  id=" + id;
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Car>(ConnectionString, comText, new DbCarHandler())[0];
        }

        public void CarEdit(Car car)
        {
            string comText =
                "Update cars set govnum=" + "'" + car.govnum + "',creator='" + car.creater +
                "',type='" + car.type + "',model='" + car.model + "',carvalue=" +
                car.valueOfCar +
                ",fueltype='" + car.fuelType + "',tankvalue=" + car.valueOfTank + ",glonasnum=" +
                +car.glonasNum +
                ",platonnum=" + car.platonNum + ",owner='" + car.owner + "',location='" + car.location + "',runned=" +
                car.runned +
                " where id=" + car.id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbCarHandler());
        }

        public void AddCar(Car car)
        {
            string comText =
                "Insert into cars(govnum,creator,type,model,carvalue,fueltype,tankvalue,glonasnum,platonnum,owner,location,runned) values('" +
                car.govnum + "','" + car.creater + "','" + car.type + "','"
                + car.model + "'," + car.valueOfCar + ",'" + car.fuelType + "'," + car.valueOfTank +
                "," + car.glonasNum + "," + car.platonNum + ",'" + car.owner + "','" + car.location + "'," +
                car.runned + ") ";

            DbExecutor.Execute(ConnectionString, comText, new DbCarHandler());
        }

        public void DeleteCar(int id)
        {
            string comText =
                "delete from cars where id=" + id;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbCarHandler());
        }

        public List<Car> GetCarsByField(string key, string field)
        {
            string comText =
                "Select * from cars where  " + field + "='" + key + "'";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Car>(ConnectionString, comText, new DbCarHandler());
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

    }
}