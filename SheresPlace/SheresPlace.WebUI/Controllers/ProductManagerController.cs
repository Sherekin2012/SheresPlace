using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using SherePlace.DataAccess.InMemory;
using SheresPlace.Core.Models;



namespace SheresPlace.WebUI.Controllers
{
    public class ProductManagerController : Controller
    {
        ProductRepository context;

        public ProductManagerController()
        {

            context = new ProductRepository();
        }
        // GET: ProductManager
        public ActionResult Index()
        {
            List<Product> products = context.Collection().ToList();
            
            return View(products);
        }

        public ActionResult Create()
        {

            Product product = new Product();
            return View(product);
        }

        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            else
            {
                context.Insert(product);
                context.Commit();

                return RedirectToAction("Index");
            }
               
            
        }

        public ActionResult Edit(string Id)
        {
            Product product = context.Find(Id);
            if(product == null)
            {
                return HttpNotFound();
            }
            else {
                return View(product);
            }
        }
    }
}
