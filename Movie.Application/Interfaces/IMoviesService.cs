using Movie.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Application.Interfaces
{
    public interface IMoviesService
    {
        IEnumerable<MoviesDtos> GetMovies();
        MoviesDtos GetMoviesById(int id);
    }
}
