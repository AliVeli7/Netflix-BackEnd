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
    public class EpisodeController : Controller
    {
        private AppDbContext _context { get; }
        public EpisodeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            var movies = await _context.Episodes
            .Where(x => x.SeasonsId == id).ToListAsync();
            return View(movies);
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Episode episode)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Episode NewEpisode = new Episode
            {
                Name = episode.Name,
                LanguageId = 1

            };
            await _context.Episodes.AddAsync(NewEpisode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
