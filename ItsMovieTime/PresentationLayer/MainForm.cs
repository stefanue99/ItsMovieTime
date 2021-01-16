using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private readonly IMovieBusiness movieBusiness;
        private readonly IAdministratorBusiness administratorBusiness;
        public MainForm(IMovieBusiness _movieBusiness, IAdministratorBusiness _administratorBusiness)
        {
            InitializeComponent();
            this.movieBusiness = _movieBusiness;
            this.administratorBusiness = _administratorBusiness;
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this.administratorBusiness);
            if (login.ShowDialog() == DialogResult.OK) 
            {
                Admins admins = new Admins(this.administratorBusiness);
                admins.Show();
            }
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            Login login = new Login(this.administratorBusiness);
            if (login.ShowDialog() == DialogResult.OK)
            {
                Movies admins = new Movies(this.movieBusiness);
                admins.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Movie> list = this.movieBusiness.GetMoviesByFilter(checkBoxWatched.Checked, checkBoxFavorite.Checked, comboBoxGenre.Text);
            list = list.Where(m => m.Title.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            dataGridView1.DataSource = list;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Movie> list = this.movieBusiness.GetAllMovies();
            dataGridView1.DataSource = list;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Watched"].Visible = false;
            dataGridView1.Columns["Favorite"].Visible = false;
            dataGridView1.Columns["OnlineLink"].Visible = false;
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Title"].Width= 350;
            dataGridView1.Columns["Rating"].Width = 60;
            dataGridView1.Columns["Genre"].Width = 130;
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null) 
            {
                int movieId = (int) dataGridView1.SelectedRows[0].Cells[0].Value;
                Movie m = this.movieBusiness.GetMovieById(movieId);
                MoviePreview mp = new MoviePreview(this.movieBusiness, m);
                mp.ShowDialog();
            }
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Movie> list = this.movieBusiness.GetMoviesByFilter(checkBoxWatched.Checked, checkBoxFavorite.Checked, comboBoxGenre.Text);
            dataGridView1.DataSource = list;
        }

        private void checkBoxFavorite_Click(object sender, EventArgs e)
        {
            List<Movie> list = this.movieBusiness.GetMoviesByFilter(checkBoxWatched.Checked, checkBoxFavorite.Checked, comboBoxGenre.Text);
            dataGridView1.DataSource = list;
        }

        private void checkBoxWatched_Click(object sender, EventArgs e)
        {
            List<Movie> list = this.movieBusiness.GetMoviesByFilter(checkBoxWatched.Checked, checkBoxFavorite.Checked, comboBoxGenre.Text);
            dataGridView1.DataSource = list;
        }
    }
}
