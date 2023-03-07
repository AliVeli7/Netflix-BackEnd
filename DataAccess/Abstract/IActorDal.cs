using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete.Models;

namespace DataAccess.Abstract
{
    public interface IActorDal:IEntityRepository<Actor>
    {
        Task<List<Actor>> GetAllAsync();
        Task<Actor> GetAsync(int id);
    }
}
