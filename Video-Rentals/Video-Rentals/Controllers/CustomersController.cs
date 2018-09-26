using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Video_Rentals.Models;


namespace Video_Rentals.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c=> c.MembershipType).ToList();


            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
            
            if (customer == null)

                return HttpNotFound();

            return View(customer);
        }
    }
}