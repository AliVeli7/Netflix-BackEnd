using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Entities.Concrete.Models;
using Entities.DTOs;

namespace DataAccess.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Genre, GenreDetailDto>().ReverseMap();
            CreateMap<Movie, MovieDetailDto>().ReverseMap();
            CreateMap<Season, SeasonDetailDto>().ReverseMap();
            CreateMap<Episode, EpisodeDetailDto>().ReverseMap(); 
            CreateMap<TvSeries, TvSeriesDetailDto>().ReverseMap();
            CreateMap<Actor, ActorDetailDto>().ReverseMap();
            CreateMap<ProductionCountry, ProductionCountryDetailDto>().ReverseMap();
            CreateMap<ProductionCompany, ProductionCompanyDetailDto>().ReverseMap();

            CreateMap<Movie, MovieDetailDto>().ForMember(dto => dto.ProductionCountries, opt => opt.MapFrom(x => x.MovieProCountries.Select(y => y.ProductionCountry).ToList()))
                .ForMember(dto => dto.Genres, opt => opt.MapFrom(x => x.MovieGenres.Select(y => y.Genre).ToList()))
                .ForMember(dto => dto.Actors, opt => opt.MapFrom(x => x.MovieActors.Select(y => y.Actor).ToList()))
                .ForMember(dto => dto.ProductionCompanies, opt => opt.MapFrom(x => x.MovieProCompanies.Select(y => y.ProductionCompany).ToList())).ReverseMap();

            CreateMap<TvSeries, TvSeriesDetailDto>().ForMember(dto => dto.ProductionCountries, opt => opt.MapFrom(x => x.TvProCountries.Select(y => y.ProductionCountry).ToList()))
               .ForMember(dto => dto.Genres, opt => opt.MapFrom(x => x.TvGenres.Select(y => y.Genre).ToList()))
               .ForMember(dto => dto.Actors, opt => opt.MapFrom(x => x.TvActors.Select(y => y.Actor).ToList()))
                .ForMember(dto => dto.Seasons, opt => opt.MapFrom(x => x.Seasons.ToList()))
               .ForMember(dto => dto.ProductionCompanies, opt => opt.MapFrom(x => x.TvProCompanies.Select(y => y.ProductionCompany).ToList())).ReverseMap();

            CreateMap<Season, SeasonDetailDto>().ForMember(dto => dto.SeasonActors, opt => opt.MapFrom(x => x.SeasonActors.Select(y => y.Actor).ToList()));


        }
    }
}
