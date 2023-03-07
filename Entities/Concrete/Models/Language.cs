using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class Language :IEntity
    {
        public Language()
        {
            Genres = new HashSet<Genre>();
            TvSeries = new HashSet<TvSeries>();
            Actors = new HashSet<Actor>();
            ProductionCompanies = new HashSet<ProductionCompany>();
            Seasons = new HashSet<Season>();
            productionCountries = new HashSet<ProductionCountry>();
            Movies = new HashSet<Movie>();
            Episodes = new HashSet<Episode>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Actor> Actors { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<ProductionCompany> ProductionCompanies { get; set; }
        public ICollection<Season> Seasons { get; set; }
        public ICollection<ProductionCountry> productionCountries { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Episode> Episodes { get; set; }
        public ICollection<TvSeries> TvSeries { get; set; }
    }
}
