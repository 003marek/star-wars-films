using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWarsFilms.Models
{
    public class RatingEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int EpisodeId { get; set; }
        [Required]
        public int FilmRating { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
