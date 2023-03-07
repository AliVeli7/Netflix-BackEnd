using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Core.Utilities.Helper;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Models;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class MovieController : Controller
    {
        private AppDbContext _context { get; }
        public MovieController( AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies
                 .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                 .Include(x => x.MovieActors).ThenInclude(x => x.Actor)
                 .Include(x => x.MovieProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.MovieProCountries).ThenInclude(x => x.ProductionCountry).OrderByDescending(x => x.Id).ToListAsync();
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
        public async Task<IActionResult> Create(Movie movie,int[] genres, int[] actors, int[] companies, int[] countries)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!movie.Poster.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Image size must be smaller than 200kb");
                return View();
            }
            if (!movie.Poster.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file  must be image");
                return View();
            }
            Movie NewProduct = new Movie
            {
                Name = movie.Name,
                ImdbId = movie.ImdbId,
                Original_language = movie.Original_language,
                Title = movie.Title,
                RunTime = movie.RunTime,
                ReleaseDate = DateTime.Now,
                LanguageId = 1,
                isDeleted = false,
                CreatedAt=DateTime.Now,
                VoteAverage=0,
                VoteCount=0,
                Adult=true,
                Budget=12345678
            };

            await _context.Movies.AddAsync(NewProduct);
            await _context.SaveChangesAsync();
            var ProductDb = _context.Movies.Find(NewProduct.Id);
            MovieActor actor; 
            foreach (var item in actors)
            {
                actor = new MovieActor();
                actor.ActorId = item;
                actor.MovieId = ProductDb.Id;
                await _context.MovieActors.AddAsync(actor);
            }
            MovieGenre genre;
            foreach (var item in genres)
            {
                genre = new MovieGenre();
                genre.GenreId = item;
                genre.MovieId = ProductDb.Id;
                await _context.MovieGenres.AddAsync(genre);
            }
            MovieProCompany company;
            foreach (var item in companies)
            {
                company = new MovieProCompany();
                company.ProductionCompanyId = item;
                company.MovieId = ProductDb.Id;
                await _context.MovieProCompanies.AddAsync(company);
            }
            MovieProCountry country;
            foreach (var item in countries)
            {
                country = new MovieProCountry();
                country.ProductionCountryId = item;
                country.MovieId = ProductDb.Id;
                await _context.MovieProCountries.AddAsync(country);
            }


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
     }
}
