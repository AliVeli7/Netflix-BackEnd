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
    public class GenreController : Controller
    {
        private AppDbContext _context { get; }
        public GenreController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var genres = await _context.Genres.ToListAsync();
            return View(genres);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Genre NewGenre = new Genre
            {
                Name = genre.Name,
                LanguageId=1
               
            };
            await _context.Genres.AddAsync(NewGenre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return BadRequest();
            Genre genre = _context.Genres.FirstOrDefault(c => c.Id == id);
            if (genre == null)
                return NotFound();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Genre genre)
        {
            if (id == null)
                return BadRequest();
            Genre genreDb = _context.Genres.FirstOrDefault(c => c.Id == id);
            if (genreDb == null)
                return NotFound();
            bool isExist = _context.Genres
                .Any(ct => ct.Name.ToLower() == genre.Name.ToLower() && ct.Id != genre.Id);
            if (isExist)
            {
                ModelState.AddModelError("Name", $"{genre.Name} is Exist");
                return View();
            }
            genreDb.Name = genre.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            Genre genreDb = _context.Genres.FirstOrDefault(c => c.Id == id);
            if (genreDb == null)
                return NotFound();
             _context.Genres.Remove(genreDb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
