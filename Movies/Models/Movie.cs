using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? Title { get; set; }

        [RangeAttribute(typeof(DateOnly), "1888-10-14", "9999-12-31")]
        public DateOnly ReleaseDate { get; set; }

        public string? Genre { get; set; }

        public string? URL { get; set; }

        [StringLength(500)]
        public string? Brief { get; set; }

        public string? Images { get; set; }

        [NotMapped]
        public IBrowserFile? ImageFile { get; set; }
    }
}