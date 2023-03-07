using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class Genre : IEntity
    {
        public Genre()
        {
            MovieGenres = new HashSet<MovieGenre>();
            TvGenres = new HashSet<TvGenre>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<TvGenre> TvGenres { get; set; }
    }
}
