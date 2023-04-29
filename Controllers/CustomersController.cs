﻿using CineRent.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CineRent.Controllers
{
    public class CustomersController : Controller
    {
        //Querying objects
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ViewResult Index()
        {
            //var customers = GetCustomers();
            //Eager Loading
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        /*private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Chinu" },
                new Customer { Id = 2, Name = "Apu" }
            };
        }*/
    }
}