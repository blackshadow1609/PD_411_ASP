using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Group
    {
        [Key]
        [Required(ErrorMessage = "ID is required")]
        public int group_id { get; set; }

        [Required(ErrorMessage = "Group name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Group Name")]
        public string? group_name { get; set; }

        [Display(Name = "Direction")]
        public byte? direction_id { get; set; }

        [Display(Name = "Year")]
        [Range(1, 5, ErrorMessage = "Year must be between 1 and 5")]
        public int? year { get; set; }

        // Navigation property
        public Direction? Direction { get; set; }
    }
}