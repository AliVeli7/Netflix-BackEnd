using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public  class SeasonDetailDto
    {
        public int Id { get; set; }
        public int TvSeriesId { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeCount { get; set; }
        public string PosterPath { get; set; }
        public ICollection<ActorDetailDto> SeasonActors { get; set; }
        public ICollection<EpisodeDetailDto> Episodes { get; set; }
    }
}
