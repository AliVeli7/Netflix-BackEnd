using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class MovieProCompany : IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ProductionCompanyId { get; set; }
        public Movie Movie { get; set; }
        public ProductionCompany ProductionCompany { get; set; }
    }
}