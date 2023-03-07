using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class TvGenre : IEntity
    {
        public int Id { get; set; }
        public TvSeries TvSeries { get; set; }
        public int TvSeriesId { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}