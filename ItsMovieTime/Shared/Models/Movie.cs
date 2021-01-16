using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; }
        public bool Watched { get; set; }
        public bool Favorite { get; set; }
        public string OnlineLink { get; set; }
        public string Description { get; set; }
    }
}
