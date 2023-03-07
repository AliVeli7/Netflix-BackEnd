using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.Models;

namespace Business.Abstract
{
    public interface ITvSeriesService
    {
        Task<List<TvSeries>> GetAllAsync();
        Task<TvSeries> GetAsync(int id);
        Task<List<TvSeries>> GetAllByGenreAsync(string genre);
        Task<List<TvSeries>> GetAllByCompanyAsync(string company);
        Task<List<TvSeries>> GetAllByActorAsync(string actor);
        Task<List<TvSeries>> GetAllByCountryAsync(string country);
    }
}
