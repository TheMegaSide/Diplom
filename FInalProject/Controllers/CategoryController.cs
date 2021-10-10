using System;
using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Controllers
{
    public class CategoryController : Controller
    {private BDService Dbservice;

        public CategoryController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        [Authorize]
        public IActionResult CategoryTablePage()
        {
            List<Category> categories = Dbservice.GetCategoryList();
            return View(categories);
        }
        public ActionResult CategoryAdd()
        {
            List<Category> categories= new List<Category>();

            using (OracleConnection con = new OracleConnection(Dbservice.ConnectionString))
            {
                con.Open();
                string comText = "select * from Categories";

                using (OracleCommand cmd = new OracleCommand(comText, con))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Category product = new Category
                        {
                            CategoryId = (int)(long)rdr["CategoryId"],
                            CategoryName = rdr["CategoryName"].ToString()
                        };
                        categories.Add(product);
                    }
                }
            }


            ViewBag.listOfProducts = categories;

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Category category)
        {
            Dbservice.AddCategory(category);
            return RedirectToAction(nameof(CategoryAdd));
        }
    }
}