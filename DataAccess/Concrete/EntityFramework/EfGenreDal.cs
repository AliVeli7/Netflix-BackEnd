using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGenreDal :EfEntityRepositoryBase<Genre, AppDbContext>, IGenreDal
    {
        public EfGenreDal(AppDbContext context) : base(context)
        {
            
        }
        public async Task<List<Genre>> GetAllAsync()
        {
            return await Context.Genres.ToListAsync();
        }

        public async Task<Genre> GetAsync(int id)
        {
            return await Context.Genres.Where(x=>x.Id==id).FirstOrDefaultAsync();
        }
    }
}
