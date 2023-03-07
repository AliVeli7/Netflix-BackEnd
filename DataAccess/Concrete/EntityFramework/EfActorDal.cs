using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfActorDal :EfEntityRepositoryBase<Actor, AppDbContext>, IActorDal
    {
        public EfActorDal(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Actor>> GetAllAsync()
        {
            return await Context.Actors.ToListAsync();
        }

        public async Task<Actor> GetAsync(int id)
        {
            return await Context.Actors.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
