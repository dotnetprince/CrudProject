using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _repository;

        public CustomerController(ApplicationDbContext repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _repository.Customers.Add(customer);
                _repository.SaveChanges();

                return RedirectToAction("index", "customer");
            }

            return View(customer);
        }


        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
