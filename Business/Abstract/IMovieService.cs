using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete.Models;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllAsync(string languageCode);
        Task<List<Movie>> GetAllByGenreAsync(string genre);
        Task<List<Movie>> GetAllByCompanyAsync(string company);
        Task<List<Movie>> GetAllByActorAsync(string actor);
        Task<List<Movie>> GetAllByCountryAsync(string country);
        Task<Movie> GetAsync(int id);
        //Task<List<MovieDetailDto>> GetMovieDetails(string languageCode);
        //IResult Add(Movie movie);

    }
}
