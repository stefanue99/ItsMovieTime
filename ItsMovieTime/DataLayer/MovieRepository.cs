using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MovieRepository : IMovieRepository
    {
        public int DeleteMovie(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Movies WHERE Id = '{0}';", Id));

            DBConnection.CloseConnection();
            return result;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> listOfMovies = new List<Movie>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Movies");

            while (sqlDataReader.Read())
            {
                Movie m = new Movie();
                m.Id = sqlDataReader.GetInt32(0);
                m.Title = sqlDataReader.GetString(1);
                m.Year = sqlDataReader.GetInt32(2);
                m.Genre = sqlDataReader.GetString(3);
                m.Rating = sqlDataReader.GetDecimal(4);
                m.Watched = sqlDataReader.GetBoolean(5);
                m.Favorite = sqlDataReader.GetBoolean(6);
                m.OnlineLink = sqlDataReader.GetString(7);
                m.Description = sqlDataReader.GetString(8);
                listOfMovies.Add(m);
            }
            DBConnection.CloseConnection();
            return listOfMovies;
        }

        public int InsertMovie(Movie m)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Movies VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", m.Title, m.Year, m.Genre,  m.Rating, m.Watched, m.Favorite, m.OnlineLink, m.Description));

            DBConnection.CloseConnection();
            return result;
        }

        public int UpdateMovie(Movie m)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Movies SET Title = '{0}', Year = '{1}', Genre = '{2}', Rating = '{3}', Watched = '{4}', Favorite = '{5}', OnlineLink = '{6}', Description = '{7}' WHERE Id = '{8}'", m.Title, m.Year, m.Genre,  m.Rating, m.Watched, m.Favorite, m.OnlineLink, m.Description, m.Id));

            DBConnection.CloseConnection();
            return result;
        }
    }
}
