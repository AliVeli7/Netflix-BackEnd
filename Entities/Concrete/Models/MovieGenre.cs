using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace Entities.Concrete.Models
{
    public class MovieGenre:IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
