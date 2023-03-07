using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete.Models;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IMovieDal:IEntityRepository<Movie>
    {
        Task<List<Movie>> GetAllAsync(string languageCode);
        Task<List<Movie>> GetAllByGenreAsync(string genre);
        Task<List<Movie>> GetAllByActorAsync(string actor);
        Task<List<Movie>> GetAllByCompanyAsync(string company);
        Task<List<Movie>> GetAllByCountryAsync(string country);
        Task<Movie> GetAsync(int id);
        // Task<MovieDetailDto> GetMovie(int id);
    }
}
