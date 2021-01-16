using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MoviePreview : Form
    {
        private Movie movie;
        private readonly IMovieBusiness movieBusiness;
        public MoviePreview(IMovieBusiness _movieBusiness, Movie m)
        {
            InitializeComponent();
            this.movieBusiness = _movieBusiness;
            movie = m;
            labelTitle.Text = m.Title;
            labelYear.Text = "Godina snimanja : " + m.Year.ToString();
            labelGenre.Text = "Zanr : " + m.Genre;
            labelRating.Text = "Ocena : " + m.Rating.ToString();
            labelDescription.Text = m.Description;
            checkBoxFavorite.Checked = m.Favorite;
            checkBoxWatched.Checked = m.Watched;
        }

        private void labelOnlineLink_Click(object sender, EventArgs e)
        {
            Process.Start(movie.OnlineLink);
        }

        private void MoviePreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            movie.Watched = checkBoxWatched.Checked;
            movie.Favorite = checkBoxFavorite.Checked;
            this.movieBusiness.UpdateMovie(movie);
        }
    }
}
