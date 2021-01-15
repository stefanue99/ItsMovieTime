using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IMovieBusiness
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        bool UpdateMovie(Movie m);
        bool DeleteMovie(int id);
        bool InsertMovie(Movie m);
        List<Movie> GetMoviesByFilter(bool watched, bool favorite, string genre);
    }
}
