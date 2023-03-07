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
    public class ProductionCompanyController : Controller
    {
        private AppDbContext _context { get; }
        public ProductionCompanyController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _context.ProductionCompanies.ToListAsync();
            return View(companies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductionCompany company)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ProductionCompany NewCompany = new ProductionCompany
            {
                Name = company.Name,
                LanguageId = 1

            };
            await _context.ProductionCompanies.AddAsync(NewCompany);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
                return BadRequest();
            ProductionCompany company = _context.ProductionCompanies.FirstOrDefault(c => c.Id == id);
            if (company == null)
                return NotFound();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ProductionCompany company)
        {
            if (id == null)
                return BadRequest();
            ProductionCompany companyDb = _context.ProductionCompanies.FirstOrDefault(c => c.Id == id);
            if (companyDb == null)
                return NotFound();
            bool isExist = _context.ProductionCompanies
                .Any(ct => ct.Name.ToLower() == company.Name.ToLower() && ct.Id != company.Id);
            if (isExist)
            {
                ModelState.AddModelError("Name", $"{company.Name} is Exist");
                return View();
            }
            companyDb.Name = company.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            ProductionCompany companyDb = _context.ProductionCompanies.FirstOrDefault(c => c.Id == id);
            if (companyDb == null)
                return NotFound();
            _context.ProductionCompanies.Remove(companyDb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
