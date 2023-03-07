using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete.Models
{
    public class Season
    {
        public Season()
        {
            SeasonActors = new HashSet<SeasonActor>();
            Episodes = new HashSet<Episode>();
        }
        public int Id { get; set; }
        public int TvSeriesId { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeCount { get; set; }
        public string PosterPath { get; set; }
        [NotMapped, Required]
        public IFormFile Poster { get; set; }
        public TvSeries TvSeries { get; set; }
        public ICollection<SeasonActor> SeasonActors { get; set; }
        public ICollection<Episode> Episodes { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}