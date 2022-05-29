using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class CarController : Controller
    {
        private BDService Dbservice;

        public CarController(BDService dbservice)
        {
            Dbservice = dbservice;
        }

        [Authorize]
        public ActionResult GetAllCars()
        {
            
            return RedirectToAction(nameof(CarTablePage));
        }
        [Authorize]
        public IActionResult CarTablePage()
        {
            List<CarNew> cars = Dbservice.GetCarsNewList();
            return View(cars);
        }
      
        
        

        public ActionResult CarAdd()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(CarNew car)
        {
            Dbservice.AddNewCar(car);
            return RedirectToAction(nameof(CarAdd));
        }

        public IActionResult CarEdit(int id)
        {
            CarNew car = Dbservice.GetCarById(id);
            return View(car);
        }

        public IActionResult Edit(CarNew car)
        {
            Dbservice.CarEdit(car);
            return RedirectToAction(nameof(CarTablePage));
        }

        public IActionResult CarDelete(int id)
        {
            CarNew car = Dbservice.GetCarById(id);
            return View(car);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            Dbservice.DeleteCar(id);
            return RedirectToAction(nameof(CarTablePage));
        }
     
        [HttpPost]
        public IActionResult CarSearch(string key, string field)
        {
            List<CarNew> cars =Dbservice.GetCarsByField(key, field);
            return View(cars);
        }



        [Authorize]
        public IActionResult GetCarListExcel()
        {   
            var data = Dbservice.GetCarsList();
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Лист 1");

                worksheet.Cell("A1").Value = "Госномер";
                worksheet.Cell("B1").Value = "Изготовитель";
                worksheet.Cell("C1").Value = "Тип автомобиля";
                worksheet.Cell("D1").Value = "Модель";
                worksheet.Cell("E1").Value = "Объем кузова";
                worksheet.Cell("F1").Value = "Тип топлива";
                worksheet.Cell("G1").Value = "Объем бензобака";
                worksheet.Cell("H1").Value = "Номер устройства ГЛОНАС";
                worksheet.Cell("I1").Value = "Номер устройства ПЛАТОН";
                worksheet.Cell("J1").Value = "Владелец";
                worksheet.Cell("K1").Value = "Местонахождение";
                worksheet.Cell("L1").Value = "Пробег";
                worksheet.Row(1).Style.Font.Bold = true;

                for (int i = 2; i < data.Count + 2; i++)
                {
                    worksheet.Cell(i, 1).Value = data[i - 2].govnum;
                    worksheet.Cell(i, 2).Value = data[i - 2].creater;
                    worksheet.Cell(i, 3).Value = data[i - 2].type;
                    worksheet.Cell(i, 4).Value = data[i - 2].model;
                    worksheet.Cell(i, 5).Value = data[i - 2].valueOfCar;
                    worksheet.Cell(i, 6).Value = data[i - 2].fuelType;
                    worksheet.Cell(i, 7).Value = data[i - 2].valueOfTank;
                    worksheet.Cell(i, 8).Value = data[i - 2].glonasNum;
                    worksheet.Cell(i, 9).Value = data[i - 2].platonNum;
                    worksheet.Cell(i, 10).Value = data[i - 2].owner;
                    worksheet.Cell(i, 11).Value = data[i - 2].location;
                    worksheet.Cell(i, 12).Value = data[i - 2].runned;
                }

                worksheet.Columns("A", "L").AdjustToContents();
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName =
                            $"Авто_Список_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        
        
        public IActionResult GetCarsNewFromExcel(string url)
        {
            XLWorkbook workbook = XLWorkbook.OpenFromTemplate("D:/Downloads/cars1.xlsx");
            var worksheet = workbook.Worksheets.Worksheet("ОБЩИЙ СПИСОК");
            for (int i = 5; i < worksheet.RowsUsed().Count()+1; i++)
            { 
                CarNew car = new CarNew()
                {
                   
                    type = worksheet.Cell(i, 1).GetString(),
                    model = worksheet.Cell(i, 2).GetString(),
                    vin = worksheet.Cell(i, 3).GetString(),
                    yearprod = (int)worksheet.Cell(i, 4).GetDouble(),
                    govnum = worksheet.Cell(i, 5).GetString(),
                    value = worksheet.Cell(i, 6).GetDouble(),
                    weight = (int)worksheet.Cell(i, 7).GetDouble(),
                    maxweight =  (int)worksheet.Cell(i, 8).GetDouble(),
                    fueltype = worksheet.Cell(i, 9).GetString(),
                    techstate = worksheet.Cell(i, 10).GetString(),
                    srokpodk = worksheet.Cell(i, 11).GetDateTime(),
                    inscomp = worksheet.Cell(i, 12).GetString(),
                    osagocost = worksheet.Cell(i, 13).GetDouble(),
                    platonnum =  worksheet.Cell(i, 14).GetString(),
                    platondate = worksheet.Cell(i, 15).GetDateTime(),
                    platonreplace = worksheet.Cell(i, 16).GetString(),
                    glonastype = worksheet.Cell(i, 17).GetString(),
                    simnum = worksheet.Cell(i, 18).GetString(),
                    glonasdate = worksheet.Cell(i, 19).GetDateTime(),
                    worktype = worksheet.Cell(i, 20).GetString(),
                    ptsowner = worksheet.Cell(i, 21).GetString(),
                    stsowner = worksheet.Cell(i, 22).GetString(),
                    regionloc = worksheet.Cell(i, 23).GetString()
                };
                
                
                    Create(car);
               
            }
            return RedirectToAction(nameof(CarTablePage));
        }
    }
}
