using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete.Models;

namespace DataAccess.Abstract
{
    public interface IProductionCountryDal:IEntityRepository<ProductionCountry>
    {
        Task<List<ProductionCountry>> GetAllAsync();
        Task<ProductionCountry> GetAsync(int id);
    }
}
