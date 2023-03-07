using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.DataAccess;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete.Models
{
    public class Movie : IEntity
    {
        public Movie()
        {
            MovieActors = new HashSet<MovieActor>();
            MovieProCountries = new HashSet<MovieProCountry>();
            MovieGenres = new HashSet<MovieGenre>();
            MovieProCompanies = new HashSet<MovieProCompany>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ImdbId { get; set; }
        public bool isDeleted { get; set; }
        public string Original_language { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string PosterUrl { get; set; }
        [NotMapped, Required]
        public IFormFile Poster { get; set; }
        public string BackDropUrl { get; set; }
        [NotMapped, Required]
        public IFormFile BackDrop { get; set; }
        public bool Adult { get; set; }
        public double Budget { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieProCompany> MovieProCompanies { get; set; }
        public ICollection<MovieProCountry> MovieProCountries { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
