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
        public IActionResult CarTablePage()
        {
            List<Car> cars = Dbservice.GetCarsList();
            return View(cars);
        }
        

        public ActionResult CarAdd()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Car car)
        {
            Dbservice.AddCar(car);
            return RedirectToAction(nameof(CarAdd));
        }

        public IActionResult CarEdit(int id)
        {
            Car car = Dbservice.GetCarById(id);
            return View(car);
        }

        public IActionResult Edit(Car car)
        {
            Dbservice.CarEdit(car);
            return RedirectToAction(nameof(CarTablePage));
        }

        public IActionResult CarDelete(int id)
        {
            Car car = Dbservice.GetCarById(id);
            return View(car);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            Dbservice.DeleteCar(id);
            return RedirectToAction(nameof(CarTablePage));
        }
        public IActionResult CarUploadExcel( )
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CarSearch(string key, string field)
        {
            List<Car> cars =Dbservice.GetCarsByField(key, field);
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

        public IActionResult GetCarsFromExcel(string url)
        {
            XLWorkbook workbook = XLWorkbook.OpenFromTemplate("D:/Downloads/cars.xlsx");
            var worksheet = workbook.Worksheets.Worksheet("Лист 1");
            for (int i = 2; i < worksheet.RowsUsed().Count()+1; i++)
            {
                Car car = new Car()
                {
                    govnum = worksheet.Cell(i, 1).GetString(),
                    creater = worksheet.Cell(i, 2).GetString(),
                    type = worksheet.Cell(i, 3).GetString(),
                    model = worksheet.Cell(i, 4).GetString(),
                    valueOfCar = worksheet.Cell(i, 5).GetDouble(),
                    fuelType = worksheet.Cell(i, 6).GetString(),
                    valueOfTank = worksheet.Cell(i, 7).GetDouble(),
                    glonasNum = (int)worksheet.Cell(i, 8).GetDouble(),
                    platonNum = (int)worksheet.Cell(i, 9).GetDouble(),
                    owner = worksheet.Cell(i, 10).GetString(),
                    location = worksheet.Cell(i, 11).GetString(),
                    runned = worksheet.Cell(i, 12).GetDouble()
                };
                Create(car);
            }
            return RedirectToAction(nameof(CarTablePage));
        }
        [HttpPost] 
        public void GetExcelUrl(string url)
        {
          
            Console.WriteLine(url);
            GetCarsFromExcel(url);
        }
    }
}
