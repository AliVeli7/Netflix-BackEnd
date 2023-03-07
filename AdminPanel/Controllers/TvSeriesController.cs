using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Helper;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class TvSeriesController : Controller
    {
        private AppDbContext _context { get; }
        public TvSeriesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.TvSeries
                  .Include(x => x.TvGenres).ThenInclude(x => x.Genre)
                  .Include(x => x.TvActors).ThenInclude(x => x.Actor)
                  .Include(x => x.TvProCompanies).ThenInclude(x => x.ProductionCompany)
                 .Include(x => x.TvProCountries).ThenInclude(x => x.ProductionCountry)
                 .Include(x=>x.Seasons).OrderByDescending(x => x.Id).ToListAsync();
            return View(movies);
        }
        public IActionResult Create()
        {
            ViewBag.genres = _context.Genres.ToList();
            ViewBag.actors = _context.Actors.ToList();
            ViewBag.companies = _context.ProductionCompanies.ToList();
            ViewBag.countries = _context.ProductionCountries.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TvSeries series, int[] genres, int[] actors, int[] companies, int[] countries)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!series.Poster.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Image size must be smaller than 200kb");
                return View();
            }
            if (!series.Poster.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file  must be image");
                return View();
            }
            TvSeries NewProduct = new TvSeries
            {
                Name = series.Name,
                ImdbId = series.ImdbId,
                Original_language = series.Original_language,
                Title = series.Title,
                RunTime = series.RunTime,
                ReleaseDate = DateTime.Now,
                LanguageId = 1,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                VoteAverage = 0,
                VoteCount = 0,
                Adult = true,
                Budget = 12345678
            };

            await _context.TvSeries.AddAsync(NewProduct);
            await _context.SaveChangesAsync();
            var ProductDb = _context.TvSeries.Find(NewProduct.Id);
            TvActor actor;
            foreach (var item in actors)
            {
                actor = new TvActor();
                actor.ActorId = item;
                actor.TvSeriesId = ProductDb.Id;
                await _context.TvActors.AddAsync(actor);
            }
            TvGenre genre;
            foreach (var item in genres)
            {
                genre = new TvGenre();
                genre.GenreId = item;
                genre.TvSeriesId = ProductDb.Id;
                await _context.TvGenres.AddAsync(genre);
            }
            TvProCompany company;
            foreach (var item in companies)
            {
                company = new TvProCompany();
                company.ProductionCompanyId = item;
                company.TvSeriesId = ProductDb.Id;
                await _context.TvProCompanies.AddAsync(company);
            }
            TvProCountry country;
            foreach (var item in countries)
            {
                country = new TvProCountry();
                country.ProductionCountryId = item;
                country.TvSeriesId = ProductDb.Id;
                await _context.TvProCountries.AddAsync(country);
            }


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        
     
    }
}
