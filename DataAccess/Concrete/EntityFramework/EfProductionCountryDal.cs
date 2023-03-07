using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductionCountryDal : EfEntityRepositoryBase<ProductionCountry, AppDbContext>, IProductionCountryDal
    {
        public EfProductionCountryDal(AppDbContext context) : base(context)
        {
        }

        public async Task<List<ProductionCountry>> GetAllAsync()
        {
            return await Context.ProductionCountries.ToListAsync();
        }

        public async Task<ProductionCountry> GetAsync(int id)
        {
            return await Context.ProductionCountries.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
