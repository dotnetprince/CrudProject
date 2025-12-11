using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _repository;

        public ProductController(ApplicationDbContext repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var products = _repository.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.Products.Add(product);
                _repository.SaveChanges();

                return RedirectToAction("index", "product");
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _repository.Products.Where(a => a.ProductId == id).FirstOrDefault();
            if (product != null)
                return View(product);

            return BadRequest();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var _prod = _repository.Products.Where(a => a.ProductId == product.ProductId).FirstOrDefault();
                _prod.ProductName = product.ProductName;
                _prod.Weight = product.Weight;
                _prod.MRP = product.MRP;
                _prod.Rate = product.Rate;
                _prod.GST = product.GST;
                _repository.SaveChanges();

                return RedirectToAction("index", "product");
            }

            return View(product);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _repository.Products.Where(a => a.ProductId == id).FirstOrDefault();
            _repository.Products.Remove(product);
            _repository.SaveChanges();
            return RedirectToAction("index", "product");
        }
    }
}
