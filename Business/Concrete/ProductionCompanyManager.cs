using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Models;

namespace Business.Concrete
{
    public class ProductionCompanyManager : IProductionCompanyService
    {
        IProductionCompanyDal _productionCompany;
        public ProductionCompanyManager(IProductionCompanyDal productionCompany)
        {
            _productionCompany = productionCompany;
        }
        public async Task<List<ProductionCompany>> GetAllAsync()
        {
            return await _productionCompany.GetAllAsync();
        }

        public async Task<ProductionCompany> GetAsync(int id)
        {
            return await _productionCompany.GetAsync(id);
        }
    }
}
