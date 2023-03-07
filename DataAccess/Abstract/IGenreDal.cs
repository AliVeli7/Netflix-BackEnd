using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Abstract
{
    public interface IGenreDal:IEntityRepository<Genre>
    {
        Task<List<Genre>> GetAllAsync();
        Task<Genre> GetAsync(int id);
    }
}
