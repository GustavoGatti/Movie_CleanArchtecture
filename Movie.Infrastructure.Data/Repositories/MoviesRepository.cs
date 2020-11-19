using Movie.Domain.Interfaces;
using Movie.Domain.Models;
using Movie.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.Infrastructure.Data.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {

        private readonly MovieDbContext _dbContext;

        public MoviesRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Domain.Models.Movies> GetMoviesById(int id)
        {
            var movie = from m in _dbContext.Movies where m.Id == id select m;
            return movie;
        }

        public IEnumerable<Domain.Models.Movies> Movies()
        {
            return _dbContext.Movies;
        }
    }
}
