using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MyCustomerController : Controller
    {
        ApplicationDbContext _dbContext;

        public MyCustomerController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: MyCustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult New(MyCustomer myCustomer)
        {
            _dbContext.MyCustomers.Add(myCustomer);
            _dbContext.SaveChanges();
            return RedirectToAction("Detail", "MyCustomer", new { id = myCustomer.Id });
        }
                
        public ActionResult Detail([Bind(Include = "id")]int id)
        {
            var customer = _dbContext.MyCustomers.Single(mc=>mc.Id.Equals(id));
            return View(customer);
        }
    }
}