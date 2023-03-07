using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class TvActor : IEntity
    {
        public int Id { get; set; }
        public TvSeries TvSeries { get; set; }
        public int TvSeriesId { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}