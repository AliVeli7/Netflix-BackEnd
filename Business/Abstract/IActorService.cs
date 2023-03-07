using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.Models;

namespace Business.Abstract
{
    public interface IActorService
    {
        Task<List<Actor>> GetAllAsync();
        Task<Actor> GetAsync(int id);
    }
}
