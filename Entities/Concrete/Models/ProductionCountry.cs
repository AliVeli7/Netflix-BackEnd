using System.Collections.Generic;
using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class ProductionCountry : IEntity
    {
        public ProductionCountry()
        {
            MovieProCountries = new HashSet<MovieProCountry>();
            TvProCountries = new HashSet<TvProCountry>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<MovieProCountry> MovieProCountries { get; set; }
        public ICollection<TvProCountry> TvProCountries { get; set; }
    }
}