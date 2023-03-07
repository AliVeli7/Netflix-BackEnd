using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EpisodeDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ImdbId { get; set; }
        public bool IsDeleted { get; set; }
        public string Original_language { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public int SeasonsId { get; set; }
    }
}
