using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        int InsertMovie(Movie m);
        int UpdateMovie(Movie m);
        int DeleteMovie(int Id);
    }
}
