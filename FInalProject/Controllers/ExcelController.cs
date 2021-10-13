using System;
using System.IO;
using ClosedXML.Excel;
using FInalProject.Services;
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

       

        

        public IActionResult GetExcel()
        {
            var data = _dbFunctionService.GetOrderList();
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Лист 1");
                
                worksheet.Cell("A1").Value = "Дата заказа";
                worksheet.Cell("B1").Value = "Дата выполнения";
                worksheet.Cell("C1").Value = "Выполнение";
                worksheet.Cell("D1").Value = "Сумма";
                worksheet.Cell("E1").Value = "Клиент";
                worksheet.Cell("F1").Value = "Cписок";
                worksheet.Row(1).Style.Font.Bold = true;

                for (int i = 2; i < data.Count + 2; i++)
                {
                    worksheet.Cell(i, 1).Value = data[i - 2].OrderDate;
                    worksheet.Cell(i, 2).Value = data[i - 2].CompletionDate;
                    worksheet.Cell(i, 3).Value = data[i - 2].Completion;
                    worksheet.Cell(i, 4).Value = data[i - 2].TotalPrice;
                    worksheet.Cell(i, 5).Value = data[i - 2].CLientname;
                    worksheet.Cell(i, 6).Value = data[i - 2].productname;
                    worksheet.Cell(i, 7).Value = data[i - 2].amount;
                    
                    
                    
                }
                worksheet.Columns("A", "H").AdjustToContents();
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName =
                            $"Отчет_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }
    }
}