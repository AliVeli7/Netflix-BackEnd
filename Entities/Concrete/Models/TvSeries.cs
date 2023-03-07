using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.DataAccess;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete.Models
{
    public class TvSeries : IEntity
    {
        public TvSeries()
        {
            TvProCountries = new HashSet<TvProCountry>();
            TvGenres = new HashSet<TvGenre>();
            Seasons = new HashSet<Season>();
            TvProCountries = new HashSet<TvProCountry>();
            TvActors = new HashSet<TvActor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ImdbId { get; set; }
        public bool IsDeleted { get; set; }
        public string Original_language { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public string PosterUrl { get; set; }
        [NotMapped, Required]
        public IFormFile Poster { get; set; }
        public bool Adult { get; set; }
        public double Budget { get; set; }
        public int SeasonNumber { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<TvGenre> TvGenres { get; set; }
        public ICollection<TvProCompany> TvProCompanies { get; set; }
        public ICollection<TvProCountry> TvProCountries { get; set; }
        public ICollection<Season> Seasons { get; set; }
        public ICollection<TvActor> TvActors { get; set; }
    }
}