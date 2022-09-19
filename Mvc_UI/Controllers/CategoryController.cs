using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_UI.Controllers
{
    public class CategoryController : Controller
    {
        // ninject
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());
        public ActionResult Index()
        {
            var values=categoryManager.IGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            categoryManager.TInsert(p);
            return RedirectToAction("Index");
        }
    }
}