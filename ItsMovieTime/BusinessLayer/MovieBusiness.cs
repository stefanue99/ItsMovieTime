using DataLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MovieBusiness : IMovieBusiness
    {
        private readonly MovieRepository movieRepository;
        public MovieBusiness() 
        {
            this.movieRepository = new MovieRepository();
        }
        public List<Movie> GetAllMovies() 
        {
            return this.movieRepository.GetAllMovies();
        }        
        public Movie GetMovieById(int id)
        {
            return this.movieRepository.GetAllMovies().FirstOrDefault(m => m.Id == id);
        }
        public List<Movie> GetMoviesByFilter(bool watched, bool favorite, string genre)
        {
            List<Movie> list = this.movieRepository.GetAllMovies();
            if (watched == true) 
            {
                list = list.Where(m => m.Watched == watched).ToList();
            }
            if (favorite == true)
            {
                list = list.Where(m => m.Favorite == favorite).ToList();
            }
            if (genre != "" )
            {
                list = list.Where(m => m.Genre == genre).ToList();
            }
            return list;

        }
        public bool InsertMovie(Movie m) 
        {
            if (this.movieRepository.InsertMovie(m) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateMovie(Movie m)
        {
            if (this.movieRepository.UpdateMovie(m) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteMovie(int id)
        {
            if (this.movieRepository.DeleteMovie(id) > 0)
            {
                return true;
            }
            return false;
        }


    }
}
