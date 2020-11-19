using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Movie.Domain.Models;

namespace Movie.Infrastructure.Data.Context
{
    public class MovieDbContext: DbContext
    {   
        public DbSet<Movie.Domain.Models.Movies> Movies { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie.Domain.Models.Movies>().ToTable("FILMES");
            modelBuilder.Entity<Movie.Domain.Models.Movies>().HasKey(e => e.Id);
            modelBuilder.Entity<Movie.Domain.Models.Movies>().Property(e => e.Id).HasColumnType("int").HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Movie.Domain.Models.Movies>().Property(e => e.Rank).HasColumnType("int").HasColumnName("RANK").IsRequired();
            modelBuilder.Entity<Movie.Domain.Models.Movies>().Property(e => e.Title).HasColumnType("varchar").HasColumnName("TITULO").HasMaxLength(250).IsRequired();
        }
    }
}
