using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.Models;

namespace Business.Abstract
{
    public interface IGenreService
    {
        Task<List<Genre>> GetAllAsync();
        Task<Genre> GetAsync(int id);
        Genre GetById(int Genreid);
    }
}
