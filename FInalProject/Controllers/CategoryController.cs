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
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Category category)
        {
            Dbservice.AddCategory(category);
            return RedirectToAction(nameof(CategoryAdd));
        }
        public IActionResult CategoryEdit(int id)
        {
            Category category = Dbservice.GetCategoryById(id);
            return View(category);
        }
        public IActionResult Edit(Category category)
        {
            Dbservice.CategoryEdit(category);
            return RedirectToAction(nameof(CategoryTablePage));
        }
        public IActionResult CategoryDelete(int id)
        {
            Category category = Dbservice.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            Dbservice.DeleteCategory(category);
            return RedirectToAction(nameof(CategoryTablePage));
        }
    }
}