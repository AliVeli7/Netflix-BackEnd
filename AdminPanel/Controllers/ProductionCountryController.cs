using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class ProductionCountryController : Controller
    {
        private AppDbContext _context { get; }
        public ProductionCountryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var countries = await _context.ProductionCountries.ToListAsync();
            return View(countries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductionCountry country)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ProductionCountry NewCountry = new ProductionCountry
            {
                Name = country.Name,
                LanguageId = 1

            };
            await _context.ProductionCountries.AddAsync(NewCountry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
                return BadRequest();
            ProductionCountry country = _context.ProductionCountries.FirstOrDefault(c => c.Id == id);
            if (country == null)
                return NotFound();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ProductionCountry country)
        {
            if (id == null)
                return BadRequest();
            ProductionCountry countryDb = _context.ProductionCountries.FirstOrDefault(c => c.Id == id);
            if (countryDb == null)
                return NotFound();
            bool isExist = _context.Genres
                .Any(ct => ct.Name.ToLower() == country.Name.ToLower() && ct.Id != country.Id);
            if (isExist)
            {
                ModelState.AddModelError("Name", $"{country.Name} is Exist");
                return View();
            }
            countryDb.Name = country.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            ProductionCountry countryDb = _context.ProductionCountries.FirstOrDefault(c => c.Id == id);
            if (countryDb == null)
                return NotFound();
            _context.ProductionCountries.Remove(countryDb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
