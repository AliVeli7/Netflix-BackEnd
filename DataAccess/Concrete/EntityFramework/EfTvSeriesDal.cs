using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTvSeriesDal : EfEntityRepositoryBase<TvSeries, AppDbContext>, ITvSeriesDal
    {
        public EfTvSeriesDal(AppDbContext context) : base(context)
        {
        }

        public async Task<List<TvSeries>> GetAllAsync()
        {
            return await Context.TvSeries
                .Include(x => x.TvGenres).ThenInclude(x => x.Genre)
                .Include(x => x.TvActors).ThenInclude(x => x.Actor)
                .Include(x => x.TvProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.TvProCountries).ThenInclude(x => x.ProductionCountry)
                .Include(x=>x.Seasons).ToListAsync();
        }

        public async Task<List<TvSeries>> GetAllByActorAsync(string actor)
        {
            return await Context.TvSeries
                .Include(x => x.TvGenres).ThenInclude(x => x.Genre)
                .Include(x => x.TvActors).ThenInclude(x => x.Actor).Where(x => x.TvActors.Any(x => x.Actor.Name == actor))
                .Include(x => x.TvProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.TvProCountries).ThenInclude(x => x.ProductionCountry)
                .Include(x => x.Seasons).ToListAsync();
        }

        public async Task<List<TvSeries>> GetAllByCompanyAsync(string company)
        {
            return await Context.TvSeries
                .Include(x => x.TvGenres).ThenInclude(x => x.Genre)
                .Include(x => x.TvActors).ThenInclude(x => x.Actor)
                .Include(x => x.TvProCompanies).ThenInclude(x => x.ProductionCompany).Where(x => x.TvProCompanies.Any(x => x.ProductionCompany.Name == company))
                .Include(x => x.TvProCountries).ThenInclude(x => x.ProductionCountry)
                .Include(x => x.Seasons).ToListAsync();
        }

        public async Task<List<TvSeries>> GetAllByCountryAsync(string country)
        {
            return await Context.TvSeries
                .Include(x => x.TvGenres).ThenInclude(x => x.Genre)
                .Include(x => x.TvActors).ThenInclude(x => x.Actor)
                .Include(x => x.TvProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.TvProCountries).ThenInclude(x => x.ProductionCountry).Where(x => x.TvProCountries.Any(x => x.ProductionCountry.Name == country))
                .Include(x => x.Seasons).ToListAsync();
        }

        public async Task<List<TvSeries>> GetAllByGenreAsync(string genre)
        {
            return await Context.TvSeries
                .Include(x => x.TvGenres).ThenInclude(x => x.Genre).Where(x => x.TvGenres.Any(x => x.Genre.Name == genre))
                .Include(x => x.TvActors).ThenInclude(x => x.Actor)
                .Include(x => x.TvProCompanies).ThenInclude(x => x.ProductionCompany)
                .Include(x => x.TvProCountries).ThenInclude(x => x.ProductionCountry)
                .Include(x => x.Seasons).ToListAsync();
        }

        public async Task<TvSeries> GetAsync(int id)
        {
            return await Context.TvSeries
                 .Include(x => x.TvGenres).ThenInclude(x => x.Genre)
                 .Include(x => x.TvActors).ThenInclude(x => x.Actor)
                 .Include(x => x.TvProCompanies).ThenInclude(x => x.ProductionCompany)
                 .Include(x => x.TvProCountries).ThenInclude(x => x.ProductionCountry)
                 .Include(x => x.Seasons).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
