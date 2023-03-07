using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class TvProCountry : IEntity
    {
        public int Id { get; set; }
        public TvSeries TvSeries { get; set; }
        public int TvSeriesId { get; set; }
        public int ProductionCountryId { get; set; }
        public ProductionCountry ProductionCountry { get; set; }
    }
}