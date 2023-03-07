using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class MovieActor : IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}