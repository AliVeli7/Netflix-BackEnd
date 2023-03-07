using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Models;

namespace Business.Concrete
{
    public class TvSeriesManager : ITvSeriesService
    {
        ITvSeriesDal _tvSeriesDal;
        public TvSeriesManager(ITvSeriesDal tvSeriesDal)
        {
            _tvSeriesDal = tvSeriesDal;
        }
        public async Task<List<TvSeries>> GetAllAsync()
        {
            return await _tvSeriesDal.GetAllAsync();
        }

        public async Task<List<TvSeries>> GetAllByActorAsync(string actor)
        {
            return await _tvSeriesDal.GetAllByActorAsync(actor);
        }

        public async Task<List<TvSeries>> GetAllByCompanyAsync(string company)
        {
            return await _tvSeriesDal.GetAllByCompanyAsync(company);
        }

        public async Task<List<TvSeries>> GetAllByCountryAsync(string country)
        {
            return await _tvSeriesDal.GetAllByCountryAsync(country);
        }

        public async Task<List<TvSeries>> GetAllByGenreAsync(string genre)
        {
            return await _tvSeriesDal.GetAllByGenreAsync(genre);
        }

        
        public async Task<TvSeries> GetAsync(int id)
        {
            return await _tvSeriesDal.GetAsync(id);
        }
    }
}
