using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Http;

namespace Entities.DTOs
{
    public class ActorDetailDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Popularity { get; set; }
        public DateTime DirthDay { get; set; }
        public string Gender { get; set; }
        public string PlaceofBirth { get; set; }
        public string ProfilePath { get; set; }
    }
}
