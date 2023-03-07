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
    public class EfProductionCompanyDal : EfEntityRepositoryBase<ProductionCompany, AppDbContext>, IProductionCompanyDal
    {
        public EfProductionCompanyDal(AppDbContext context) : base(context)
        {
        }

        public async Task<List<ProductionCompany>> GetAllAsync()
        {
            return await Context.ProductionCompanies.ToListAsync();
        }

        public async Task<ProductionCompany> GetAsync(int id)
        {
            return await Context.ProductionCompanies.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
