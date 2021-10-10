using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FInalProject.Models;
using FInalProject.Services;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Controllers
{
    public class ProductController : Controller
    {
        private BDService Dbservice;

        public ProductController(BDService dbservice)
        {
            Dbservice = dbservice;
        }

        [Authorize]
        [HttpGet]
        public IActionResult ProductTablePage()
        {
            List<Product> products = Dbservice.GetProductList();
            return View(products);
        }

        public ActionResult ProductAdd()
        {
            List<Product> products = new List<Product>();

            using (OracleConnection con = new OracleConnection(Dbservice.ConnectionString))
            {
                con.Open();
                string comText = "select * from Products";

                using (OracleCommand cmd = new OracleCommand(comText, con))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Product product = new Product
                        {
                            ProductName = rdr["ProductName"].ToString(),
                            ProductIndex = rdr["ProductIndex"].ToString(),
                            ProductUnit = rdr["ProductUnit"].ToString(),
                            CategoryId = (decimal) rdr["CategoryId"],
                            SellerId = (decimal) rdr["SellerId"],
                            StockId = (decimal) rdr["StockId"],
                            ProductPrice = (decimal) rdr["ProductPrice"],
                            ProductDate = (DateTime) rdr["ProductDate"],
                            Amount = (decimal) rdr["Amount"]
                        };
                        products.Add(product);
                    }
                }
            }


            ViewBag.listOfProducts = products;

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Product product)
        {
            Dbservice.AddProduct(product);
            return RedirectToAction(nameof(ProductAdd));
        }

        public IActionResult EditProduct(int id)
        {
            List<Product> products = new List<Product>();
            using (OracleConnection con = new OracleConnection(Dbservice.ConnectionString))
            {
                con.Open();
                string comText = "select * from Products";
                using (OracleCommand cmd = new OracleCommand(comText, con))
                {
                    
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Product product = new Product
                        {
                            ProductName =  rdr["ProductName"].ToString(),
                            ProductIndex = rdr["ProductIndex"].ToString(),
                            ProductUnit = rdr["ProductUnit"].ToString(),
                            CategoryId = (decimal) rdr["CategoryId"],
                            SellerId = (decimal)rdr["SellerId"],
                            StockId = (decimal)rdr["StockId"],
                            ProductPrice = (decimal)rdr["ProductPrice"],
                            ProductDate = (DateTime)rdr["ProductDate"],
                            Amount = (decimal)rdr["Amount"]
                        };
                        products.Add(product);
                    }
                }
            }


            ViewBag.listOfProducts = products;
        

            Product prod = Dbservice.GetProductById(id);
            return View(prod);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            Dbservice.EditProduct(product);
            return RedirectToAction(nameof(EditProduct));
        }
        //
        // public IActionResult Delete(int id)
        // {
        //     Dog dog = _dogService.GetDogById(id);
        //     return View(dog);
        // }
        //
        // [HttpPost]
        // public IActionResult Delete(Dog dog)
        // {
        //     _dogService.DeleteDog(dog);
        //     return RedirectToAction(nameof(Index));
        // }
    }
}