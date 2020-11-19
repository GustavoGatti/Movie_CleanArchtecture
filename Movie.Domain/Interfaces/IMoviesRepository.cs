using Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.Domain.Interfaces
{
    public interface IMoviesRepository
    {
        IEnumerable<Movies> Movies();
        IQueryable<Movies> GetMoviesById(int id);

    }
}
