using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class MovieProCountry : IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ProductionCountryId { get; set; }
        public Movie Movie { get; set; }
        public ProductionCountry ProductionCountry { get; set; }
    }
}