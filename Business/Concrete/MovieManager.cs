using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.Models;
using Entities.DTOs;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;
        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(MovieValidator))]
        public IResult Add(Movie movie)
        {
            IResult result = BusinessRules.Run();
            if (result!=null)
            {
                return result;
            }

            _movieDal.Add(movie);

            return result;
        }

        public async Task<List<Movie>> GetAllAsync(string languageCode)
        {
            return await _movieDal.GetAllAsync(languageCode);
        }

        public async Task<List<Movie>> GetAllByActorAsync(string actor)
        {
            return await _movieDal.GetAllByActorAsync(actor);
        }

        public async Task<List<Movie>> GetAllByCompanyAsync(string company)
        {
            return await _movieDal.GetAllByCompanyAsync(company);
        }

        public async Task<List<Movie>> GetAllByCountryAsync(string country)
        {
            return await _movieDal.GetAllByCountryAsync(country);
        }

        public async Task<List<Movie>> GetAllByGenreAsync(string genre)
        {
            return await _movieDal.GetAllByGenreAsync(genre);
        }

        public async Task<Movie> GetAsync(int id)
        {
            return await _movieDal.GetAsync(id);
        }
    }
}
