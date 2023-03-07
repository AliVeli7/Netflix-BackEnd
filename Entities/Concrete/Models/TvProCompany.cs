using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class TvProCompany : IEntity
    {
        public int Id { get; set; }
        public TvSeries TvSeries { get; set; }
        public int TvSeriesId { get; set; }
        public int ProductionCompanyId { get; set; }
        public ProductionCompany ProductionCompany { get; set; }
    }
}