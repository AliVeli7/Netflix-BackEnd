using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.Models;

namespace Business.Abstract
{
    public interface IProductionCompanyService
    {
        Task<List<ProductionCompany>> GetAllAsync();
        Task<ProductionCompany> GetAsync(int id);
    }
}
