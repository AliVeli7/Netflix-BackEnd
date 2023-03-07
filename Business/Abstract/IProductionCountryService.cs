using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.Models;

namespace Business.Abstract
{
    public interface IProductionCountryService
    {
        Task<List<ProductionCountry>> GetAllAsync();
        Task<ProductionCountry> GetAsync(int id);
    }
}
