using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.DataAccess;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete.Models
{
    public class Actor:IEntity
    {
        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
            TvActors = new HashSet<TvActor>();
            SeasonActors = new HashSet<SeasonActor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Popularity { get; set; }
        public DateTime DirthDay { get; set; }
        public string Gender { get; set; }
        public string PlaceofBirth { get; set; }
        public string ProfilePath { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
        public ICollection<TvActor> TvActors { get; set; }
        public ICollection<SeasonActor> SeasonActors { get; set; }
    }
}
