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
    public partial class Movies : Form
    {
        private readonly IMovieBusiness movieBusiness;
        public Movies()
        {
            InitializeComponent();
            this.movieBusiness = new MovieBusiness();
            

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxTitle.Text != "" && textBoxYear.Text != "" && textBoxRating.Text != "" && textBoxLink.Text != "" && richTextBoxDescription.Text != "")
            {
                Movie movie = new Movie()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Title = textBoxTitle.Text,
                    Year = Convert.ToInt32(textBoxYear.Text),
                    Description = richTextBoxDescription.Text,
                    Genre = comboBoxGenre.Text,
                    OnlineLink = textBoxLink.Text,
                    Rating = Convert.ToDecimal(textBoxRating.Text)
                };
                if (this.movieBusiness.UpdateMovie(movie) == true)
                {
                    MessageBox.Show("Uspesna izmjena");
                    List<Movie> list = this.movieBusiness.GetAllMovies();
                    dataGridView1.DataSource = list;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }
        public void Clear() 
        {
            textBoxId.Text = "";
            textBoxLink.Text = "";
            textBoxRating.Text = "";
            textBoxTitle.Text = "";
            textBoxYear.Text = "";
            richTextBoxDescription.Text = "";
            comboBoxGenre.SelectedIndex = -1;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != "" && textBoxYear.Text != "" && textBoxRating.Text != "" && textBoxLink.Text != "" && richTextBoxDescription.Text != "")
            {
                Movie movie = new Movie()
                {
                    Title = textBoxTitle.Text,
                    Year = Convert.ToInt32(textBoxYear.Text),
                    Description = richTextBoxDescription.Text,
                    Genre = comboBoxGenre.Text,
                    OnlineLink = textBoxLink.Text,
                    Rating = Convert.ToDecimal(textBoxRating.Text)
                };
                if (this.movieBusiness.InsertMovie(movie) == true)
                {
                    MessageBox.Show("Uspesno dodavanje");
                    List<Movie> list = this.movieBusiness.GetAllMovies();
                    dataGridView1.DataSource = list;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (this.movieBusiness.DeleteMovie(id) == true)
                {
                    MessageBox.Show("Uspesno brisanje");
                    List<Movie> list = this.movieBusiness.GetAllMovies();
                    dataGridView1.DataSource = list;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            List<Movie> list = this.movieBusiness.GetAllMovies();
            dataGridView1.DataSource = list;
            dataGridView1.Columns["Watched"].Visible = false;
            dataGridView1.Columns["Favorite"].Visible = false;
            dataGridView1.Columns["Rating"].Width = 50;
            dataGridView1.Columns["Year"].Width = 60;
            dataGridView1.Columns["Genre"].Width = 130;
            dataGridView1.Columns["Id"].Width = 50;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxYear.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxGenre.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxRating.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            richTextBoxDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxLink.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
