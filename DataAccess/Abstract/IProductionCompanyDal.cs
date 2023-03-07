using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete.Models;

namespace DataAccess.Abstract
{
    public interface IProductionCompanyDal : IEntityRepository<ProductionCompany>
    {
        Task<List<ProductionCompany>> GetAllAsync();
        Task<ProductionCompany> GetAsync(int id);
    }
}
