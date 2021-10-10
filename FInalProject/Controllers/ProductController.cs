using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            Product prod = Dbservice.GetProductById(id);
            return View(prod);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            Dbservice.ProductEdit(product);
            return RedirectToAction(nameof(ProductTablePage));
        }

        public IActionResult ProductDelete(int id)
        {
            Product product = Dbservice.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            Dbservice.DeleteProduct(product);
            return RedirectToAction(nameof(ProductTablePage));
        }
    }
}