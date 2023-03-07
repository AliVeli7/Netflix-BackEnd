﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Http;

namespace Entities.DTOs
{
    public class MovieDetailDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ImdbId { get; set; }
        public bool isDeleted { get; set; }
        public string Original_language { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }
        public string BackDropUrl { get; set; }
        public int VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public int LanguageId { get; set; }
        public bool Adult { get; set; }
        public double Budget { get; set; }
        public ICollection<GenreDetailDto> Genres { get; set; }
        public ICollection<ActorDetailDto> Actors { get; set; }
        public ICollection<ProductionCompanyDetailDto> ProductionCompanies { get; set; }
        public ICollection<ProductionCountryDetailDto> ProductionCountries { get; set; }
    }
}
