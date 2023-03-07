using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Models;

namespace Business.Concrete
{
    public class ActorManager :IActorService
    {
        IActorDal _actorDal;
        public ActorManager(IActorDal actorDal)
        {
            _actorDal = actorDal;
        }

        public async Task<List<Actor>> GetAllAsync()
        {
            return await _actorDal.GetAllAsync();
        }

        public async Task<Actor> GetAsync(int id)
        {
            return await _actorDal.GetAsync(id);
        }
    }
}
