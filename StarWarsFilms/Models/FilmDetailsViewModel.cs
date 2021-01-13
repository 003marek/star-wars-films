using System;
using System.Collections.Generic;

namespace StarWarsFilms.Models
{
    public class FilmDetailsViewModel
    {
        public FilmViewModel Film { get; set; }
        public IEnumerable<RatingViewModel> Ratings;
    }
}
