using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public IConfiguration configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("Default");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
           .Entity<MovieActor>()
           .HasOne(e => e.Actor)
           .WithMany(e => e.MovieActors)
           .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<MovieActor>()
           .HasOne(e => e.Movie)
           .WithMany(e => e.MovieActors)
           .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
        .Entity<MovieGenre>()
       .HasOne(e => e.Genre)
       .WithMany(e => e.MovieGenres)
       .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<MovieGenre>()
           .HasOne(e => e.Movie)
           .WithMany(e => e.MovieGenres)
           .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
        .Entity<MovieProCompany>()
       .HasOne(e => e.ProductionCompany)
       .WithMany(e => e.MovieProCompanies)
       .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<MovieProCompany>()
           .HasOne(e => e.Movie)
           .WithMany(e => e.MovieProCompanies)
           .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
        .Entity<MovieProCountry>()
       .HasOne(e => e.ProductionCountry)
       .WithMany(e => e.MovieProCountries)
       .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<MovieProCountry>()
           .HasOne(e => e.Movie)
           .WithMany(e => e.MovieProCountries)
           .OnDelete(DeleteBehavior.ClientCascade);


            modelBuilder
       .Entity<TvProCountry>()
      .HasOne(e => e.ProductionCountry)
      .WithMany(e => e.TvProCountries)
      .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<TvProCountry>()
           .HasOne(e => e.TvSeries)
           .WithMany(e => e.TvProCountries)
           .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
       .Entity<TvProCompany>()
      .HasOne(e => e.ProductionCompany)
      .WithMany(e => e.TvProCompanies)
      .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<TvProCompany>()
           .HasOne(e => e.TvSeries)
           .WithMany(e => e.TvProCompanies)
           .OnDelete(DeleteBehavior.ClientCascade);


            modelBuilder
        .Entity<TvActor>()
        .HasOne(e => e.Actor)
        .WithMany(e => e.TvActors)
        .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<TvActor>()
           .HasOne(e => e.TvSeries)
           .WithMany(e => e.TvActors)
           .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
        .Entity<TvGenre>()
       .HasOne(e => e.Genre)
       .WithMany(e => e.TvGenres)
       .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
           .Entity<TvGenre>()
           .HasOne(e => e.TvSeries)
           .WithMany(e => e.TvGenres)
           .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
       .Entity<Season>()
      .HasOne(e => e.TvSeries)
      .WithMany(e => e.Seasons)
      .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
      .Entity<Episode>()
     .HasOne(e => e.Season)
     .WithMany(e => e.Episodes)
     .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
      .Entity<SeasonActor>()
     .HasOne(e => e.Actor)
     .WithMany(e => e.SeasonActors)
     .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder
      .Entity<SeasonActor>()
     .HasOne(e => e.Season)
     .WithMany(e => e.SeasonActors)
     .OnDelete(DeleteBehavior.ClientCascade);
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<TvGenre> TvGenres { get; set; }
        public DbSet<TvProCompany> TvProCompanies { get; set; }
        public DbSet<TvProCountry> TvProCountries { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<TvActor> TvActors { get; set; }
        public DbSet<SeasonActor> SeasonActors { get; set; }
        public DbSet<MovieProCompany> MovieProCompanies { get; set; }
        public DbSet<MovieProCountry> MovieProCountries { get; set; }
        public DbSet<ProductionCompany> ProductionCompanies { get; set; }
        public DbSet<Season> Seasons { get; set; }
       public DbSet<TvSeries> TvSeries { get; set; }
        public DbSet<ProductionCountry> ProductionCountries { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
