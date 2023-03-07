using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class ProductionCompany:IEntity
    {
        public ProductionCompany()
        {
            MovieProCompanies = new HashSet<MovieProCompany>();
            TvProCompanies = new HashSet<TvProCompany>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<MovieProCompany> MovieProCompanies { get; set; }
        public ICollection<TvProCompany> TvProCompanies { get; set; }
    }
}
