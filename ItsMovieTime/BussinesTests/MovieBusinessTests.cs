using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace BussinesTests
{
    [TestClass]
    public class MovieBusinessTests
    {

        private Mock<IMovieRepository> mockMovieRepository = new Mock<IMovieRepository>();
        private Movie movie = new Movie
        {
            Id = 25,
            Title = "Profesionalac",
            Year = 2002,
            Favorite = false,
            Watched = false,
            Genre = "Komedjia",
            Description = "Profesionalac",
            OnlineLink = "link",
            Rating = 8.1m
        };
        private List<Movie> listOfMovies = new List<Movie>();
        private MovieBusiness movieBusiness;

        [TestMethod]
        public void MovieDeleted()
        {
            //Arange
            mockMovieRepository.Setup(a => a.DeleteMovie(movie.Id)).Returns(1);
            this.movieBusiness = new MovieBusiness(mockMovieRepository.Object);

            //Act
            var result = this.movieBusiness.DeleteMovie(movie.Id);

            //Asert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GetMovietById()
        {
            //Arange
            listOfMovies.Add(new Movie
            {
                Id = 25,
                Title = "Profesionalac",
                Year = 2002,
                Favorite = false,
                Watched = false,
                Genre = "Komedjia",
                Description = "Profesionalac",
                OnlineLink = "link",
                Rating = 8.1m
            });
            listOfMovies.Add(new Movie
            {
                Id = 30,
                Title = "Bumerang",
                Year = 2002,
                Favorite = false,
                Watched = false,
                Genre = "Komedjia",
                Description = "Profesionalac",
                OnlineLink = "link",
                Rating = 8.1m
            });
            listOfMovies.Add(new Movie
            {
                Id = 35,
                Title = "Crna macka beli macor",
                Year = 2002,
                Favorite = false,
                Watched = false,
                Genre = "Komedjia",
                Description = "Profesionalac",
                OnlineLink = "link",
                Rating = 8.1m
            });
            mockMovieRepository.Setup(x => x.GetAllMovies()).Returns(listOfMovies);
            this.movieBusiness = new MovieBusiness(mockMovieRepository.Object);

            //Act
            var result = this.movieBusiness.GetMovieById(25);

            //Assert
            Assert.AreEqual("Profesionalac", result.Title);
        }

        [TestMethod]
        public void MovieInserted()
        {

            //Arange
            mockMovieRepository.Setup(x => x.InsertMovie(movie)).Returns(1);
            this.movieBusiness = new MovieBusiness(mockMovieRepository.Object);

            //Act
            var result = this.movieBusiness.InsertMovie(movie);

            //Asert
            Assert.IsTrue(result);

        }
    }
}
