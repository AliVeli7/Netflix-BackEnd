using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class SeasonActor : IEntity
    {
        public int Id { get; set; }
        public Season Season { get; set; }
        public int SeasonsId { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}