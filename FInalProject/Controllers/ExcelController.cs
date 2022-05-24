using System;
using System.IO;
using ClosedXML.Excel;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class ExcelController : Controller
    {
       private BDService _dbFunctionService;

        public ExcelController(BDService dbFunctionService)
        {
            _dbFunctionService = dbFunctionService;
        }

       

        
        [Authorize]
        public IActionResult GetCarExcel()
        {
            var data = _dbFunctionService.GetCarsList();
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
    }
}