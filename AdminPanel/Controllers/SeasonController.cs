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
    public class SeasonController : Controller
    {
        private AppDbContext _context { get; }
        public SeasonController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
             var movies = await _context.Seasons
                      .Where(x => x.TvSeriesId == id).ToListAsync();
               return View(movies);
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Season season)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Season NewSeason = new Season
            {

            };
            await _context.Seasons.AddAsync(NewSeason);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
