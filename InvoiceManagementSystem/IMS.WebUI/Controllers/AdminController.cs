using IMS.Contracts.Repositories;
using IMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS.WebUI.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        IBaseRepository<Customer> customers;
        IBaseRepository<Product> products;
        public AdminController(IBaseRepository<Customer> customers,IBaseRepository<Product> products){
           this.customers = customers;
           this.products = products;
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProductList() {
            var model = products.GetAll();
            return View(model);
        }


    }
}
