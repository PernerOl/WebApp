using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovie.Models;

namespace MvcMovie.ViewModels
{
    public class MovieViewModel
    {
        public MovieViewModel(Movie movie)
        {
            ID = movie.ID;
            Genre = movie.Genre;
            Price = movie.Price;
            Title = movie.Title;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
