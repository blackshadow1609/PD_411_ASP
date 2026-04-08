using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Direction
    {
        [Key]
        [Required(ErrorMessage = "ID is required")]
        public byte direction_id { get; set; }

        [Required(ErrorMessage = "Direction name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        [Display(Name = "Direction Name")]
        public string? direction_name { get; set; }
    }
}