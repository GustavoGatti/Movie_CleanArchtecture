using Movie.Application.Dtos;
using Movie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Application.Service
{
    public class MoviesService : IMoviesService
    {
        /*
        private readonly IMoviesRepository _moviesRepository;

        public MoviesService(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }
        */

        public MoviesDtos GetMoviesById(int id)
        {
            //var movie = _moviesRepository.GetMovieById(id).FirstOrDefault();

            var movieDto = new MoviesDtos()
            {
                //codigo_filme = movie.Id,
                //nome_filme = movie.Title,
                //nota = movie.Rank
            };

            return movieDto;
        }

        IEnumerable<MoviesDtos> IMoviesService.GetMovies()
        {
            List<MoviesDtos> moviesDtos = new List<MoviesDtos>();

            /*
            var movies = _moviesRepository.GetMovies();

            foreach (var movie in movies)
            {
                moviesDtos.Add(new MoviesDtos()
                {
                    codigo_filme = movie.Id,
                    nome_filme = movie.Title,
                    nota = movie.Rank
                });
            }

            */
            return moviesDtos;
        }
    }
}
