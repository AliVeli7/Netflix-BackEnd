using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete.Models;

namespace DataAccess.Abstract
{
    public interface ITvSeriesDal : IEntityRepository<TvSeries>
    {
        Task<List<TvSeries>> GetAllAsync();
        Task<List<TvSeries>> GetAllByGenreAsync(string genre);
        Task<List<TvSeries>> GetAllByActorAsync(string actor);
        Task<List<TvSeries>> GetAllByCompanyAsync(string company);
        Task<List<TvSeries>> GetAllByCountryAsync(string country);
        Task<TvSeries> GetAsync(int id);
    }
}
