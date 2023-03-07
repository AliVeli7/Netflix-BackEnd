using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Models;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfMovieDal : EfEntityRepositoryBase<Movie, AppDbContext>, IMovieDal
    {
        public EfMovieDal(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Movie>> GetAllAsync(string languageCode)
        {
            return await Context.Movies
                 .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.MovieActors).ThenInclude(x => x.Actor)
                .Include(x => x.MovieProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.MovieProCountries).ThenInclude(x => x.ProductionCountry).OrderByDescending(x => x.Id).Take(6).ToListAsync();
        }

        public async Task<List<Movie>> GetAllByActorAsync(string actor)
        {
            return await Context.Movies
                .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.MovieActors).ThenInclude(x => x.Actor).Where(x => x.MovieActors.Any(x => x.Actor.Name == actor))
                .Include(x => x.MovieProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.MovieProCountries).ThenInclude(x => x.ProductionCountry).ToListAsync();
        }

        public async Task<List<Movie>> GetAllByCompanyAsync(string company)
        {
            return await Context.Movies
                .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.MovieActors).ThenInclude(x => x.Actor)
                .Include(x => x.MovieProCompanies).ThenInclude(x => x.ProductionCompany).Where(x => x.MovieProCompanies.Any(x => x.ProductionCompany.Name == company))
                .Include(x => x.MovieProCountries).ThenInclude(x => x.ProductionCountry).ToListAsync();
        }

        public async Task<List<Movie>> GetAllByCountryAsync(string country)
        {
            return await Context.Movies
                .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.MovieActors).ThenInclude(x => x.Actor)
                .Include(x => x.MovieProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.MovieProCountries).ThenInclude(x => x.ProductionCountry).Where(x => x.MovieProCountries.Any(x => x.ProductionCountry.Name == country))
                .ToListAsync();
        }

        public async Task<List<Movie>> GetAllByGenreAsync(string genre)
        {
            return await Context.Movies
                .Include(x=>x.MovieGenres).ThenInclude(x=>x.Genre).Where(x=>x.MovieGenres.Any(x=>x.Genre.Name==genre))
                .Include(x => x.MovieActors).ThenInclude(x => x.Actor)
                .Include(x => x.MovieProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.MovieProCountries).ThenInclude(x => x.ProductionCountry).ToListAsync();
                
        }

        public async Task<Movie> GetAsync(int id)
        {
            return await Context.Movies
                .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.MovieActors).ThenInclude(x => x.Actor)
                .Include(x => x.MovieProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.MovieProCountries).ThenInclude(x => x.ProductionCountry)
                .Where(x=>x.Id==id).FirstOrDefaultAsync();
        }
    }
}
 