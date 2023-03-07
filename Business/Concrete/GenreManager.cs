using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Models;

namespace Business.Concrete
{
    public class GenreManager : IGenreService
    {
        IGenreDal _genreDal;
        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }

        public async Task<List<Genre>> GetAllAsync()
        {
            return await _genreDal.GetAllAsync();
        }

        public Genre GetById(int Genreid)
        {
            throw new NotImplementedException();
        }

        public async Task<Genre> GetAsync(int id)
        {
            return await _genreDal.GetAsync(id);
        }
    }
}
