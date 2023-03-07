using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Models;

namespace Business.Concrete
{
    public class ProductionCountryManager : IProductionCountryService
    {
        IProductionCountryDal _productionCountry;
        public ProductionCountryManager(IProductionCountryDal productionCountry)
        {
            _productionCountry = productionCountry;
        }
        public async Task<List<ProductionCountry>> GetAllAsync()
        {
            return await _productionCountry.GetAllAsync();
        }

        public async Task<ProductionCountry> GetAsync(int id)
        {
            return await _productionCountry.GetAsync(id);
        }
    }
}
