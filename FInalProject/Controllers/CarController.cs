using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using FInalProject.Atribute;
using FInalProject.Data;
using FInalProject.Models;
using FInalProject.Services;
using FInalProject.Util.DB;
using FInalProject.Util.DbHandlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Word = Microsoft.Office.Interop.Word;
using GemBox.Document;
using GemBox.Document.Tables;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Bookmark = FInalProject.Services.Bookmark;

namespace FInalProject.Controllers
{
    public class CarController : Controller
    {
        private Document doc = null;
        private BDService Dbservice;
        
        public CarController(BDService dbservice)
        {
            Dbservice = dbservice;
            
        }

        
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult GetAllCars()
        {
            
            return RedirectToAction(nameof(CarTablePage));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult CarTablePage()
        {
            List<CarNew> cars = Dbservice.GetCarsNewList();
            ViewBag.Cars = cars;
            return View(cars);
        }
      
        
        
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult CarAdd()
        {
            return View();
        }

        [HttpPost]
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult Create(CarNew car)
        {
            Dbservice.AddNewCar(car);
            return RedirectToAction(nameof(CarAdd));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult CarEdit(int id)
        {
            CarNew car = Dbservice.GetCarById(id);
            return View(car);
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult Edit(CarNew car)
        {
            Dbservice.CarEdit(car);
            return RedirectToAction(nameof(CarTablePage));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        

        [HttpPost]
        [AuthorizeRoles(Roles.SuperAdmin)]
        public IActionResult Delete(int id)
        {
            Dbservice.DeleteCar(id);
            return RedirectToAction(nameof(CarTablePage));
        }
     
        [HttpPost]
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult CarSearch(string key, string field)
        {
            List<CarNew> cars =Dbservice.GetCarsByField(key, field);
            ViewBag.Cars = cars;
            return View(cars);
        }



        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        [HttpPost]
        public IActionResult GetCarListExcel(List<CarNew> data)
        {   Console.WriteLine(data[1].govnum);
            //var data = Dbservice.GetCarsNewList();
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
                    worksheet.Cell(i, 1).Value = data[i - 2].type;
                    worksheet.Cell(i, 2).Value = data[i - 2].model;
                    worksheet.Cell(i, 3).Value = data[i - 2].vin;
                    worksheet.Cell(i, 4).Value = data[i - 2].yearprod;
                    worksheet.Cell(i, 5).Value = data[i - 2].govnum;
                    worksheet.Cell(i, 6).Value = data[i - 2].value;
                    worksheet.Cell(i, 7).Value = data[i - 2].weight;
                    worksheet.Cell(i, 8).Value = data[i - 2].maxweight;
                    worksheet.Cell(i, 9).Value = data[i - 2].fueltype;
                    worksheet.Cell(i, 10).Value = data[i - 2].techstate;
                    worksheet.Cell(i, 11).Value = data[i - 2].srokpodk;
                    worksheet.Cell(i, 12).Value = data[i - 2].inscomp;
                    worksheet.Cell(i, 13).Value = data[i - 2].osagocost;
                    worksheet.Cell(i, 14).Value = data[i - 2].platonnum;
                    worksheet.Cell(i, 15).Value = data[i - 2].platondate;
                    worksheet.Cell(i, 16).Value = data[i - 2].platonreplace;
                    worksheet.Cell(i, 17).Value = data[i - 2].glonastype;
                    worksheet.Cell(i, 18).Value = data[i - 2].simnum;
                    worksheet.Cell(i, 19).Value = data[i - 2].glonasdate;
                    worksheet.Cell(i, 20).Value = data[i - 2].worktype;
                    worksheet.Cell(i, 21).Value = data[i - 2].ptsowner;
                    worksheet.Cell(i, 22).Value = data[i - 2].stsowner;
                    worksheet.Cell(i, 23).Value = data[i - 2].regionloc;
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

        
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
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
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        List<TO> GetTOByAuto(int autoid)
        {
            string comText =
                "select max(date),totype from (select date, totype from \"to\" where auto="+autoid+" and state='Выполнено') smsel group by totype";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<TO>("Server=127.0.0.1;User Id=postgres;Password=6851;Database=Dilpom;", comText, new TOReqHandler());
        }
        // public TextRange ReplaceContent(string bookmarkName, string text, bool saveFormatting)
        // {
        //     BookmarksNavigator navigator = new BookmarksNavigator(doc);
        //     navigator.MoveToBookmark(bookmarkName);//Point to a specific bookmark
        //     navigator.DeleteBookmarkContent(saveFormatting);//Delete the original bookmark content     
        //     Spire.Doc.Interface.ITextRange textRange = navigator.InsertText(text);//Write text
        //     return textRange as TextRange;
        // }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult GetAutoDoc(int id)
        {
            Document doc = new Document();
            doc.LoadFromFile("D:/Downloads/ПАСПОРТ.docx");
            
            Bookmark bookmark = new Bookmark(doc);
            
            CarNew car = Dbservice.GetCarById(id);
            List<TO> tos = GetTOByAuto(id);
            
            
            bookmark.ReplaceContent("MODEL", car.model, true);
            bookmark.ReplaceContent("TYPE", car.type, true);
            bookmark.ReplaceContent("YEARPROD", car.yearprod.ToString(), true);
            bookmark.ReplaceContent("VIN", car.vin, true);
            bookmark.ReplaceContent("GOVNUM", car.govnum, true);
            bookmark.ReplaceContent("OWNER", car.ptsowner, true);
            bookmark.ReplaceContent("DATE", "\""+DateTime.Now.Day+"\" "+DateTime.Now.Month+" "+DateTime.Now.Year, true);


            try
            {
                bookmark.ReplaceContent("TOTYPE1", tos[0].toType, true);
                
                bookmark.ReplaceContent("TODATE1", tos[0].date.ToShortDateString(), true);
            
                
                bookmark.ReplaceContent("TOTYPE2", tos[1].toType, true);
                bookmark.ReplaceContent("TODATE2", tos[1].date.ToShortDateString(), true);
            }
            catch(Exception)
            {}
                
                
                
            doc.SaveToFile("D:/Downloads/AutoPass_"+car.govnum+".docx", FileFormat.Docx);
            
            return RedirectToAction(nameof(CarTablePage));
        }
        
        
    }
}
