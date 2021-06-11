using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class CategoriesController : Controller
    {
        private List<Category> _categories = new List<Category>();
        public CategoriesController()
        {
            _categories.Add(new Category()
            {
                Id = 1,
                Name = "English",
                Description = "Improve English",
            });

            _categories.Add(new Category()
            {
                Id = 2,
                Name = "Math",
                Description = "Physical Math",
            });

        }
        // GET: Categories
        public ActionResult Index()
        {
            return View(_categories);
        }
        public ActionResult Details(int id)
        {
            var category = _categories.SingleOrDefault(t => t.Id == id);
            if (category == null) return HttpNotFound();
            return View(category);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}