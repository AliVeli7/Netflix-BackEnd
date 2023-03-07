using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class ActorController : Controller
    {
        private AppDbContext _context { get; }
        public ActorController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var actor = await _context.Actors.ToListAsync();
            return View(actor);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Actor NewActor = new Actor
            {
                Name = actor.Name,
                SurName=actor.SurName,
                BirthDay=actor.BirthDay,
                Popularity=0,
                Gender=actor.Gender,
                PlaceofBirth=actor.PlaceofBirth,
                DirthDay=DateTime.Now,
                LanguageId = 1

            };
            await _context.Actors.AddAsync(NewActor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
