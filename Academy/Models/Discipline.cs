using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Discipline
    {
        [Key]
        [Required(ErrorMessage = "ID is required")]
        public short discipline_id { get; set; }

        [Required(ErrorMessage = "Discipline name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        [Display(Name = "Discipline Name")]
        public string? discipline_name { get; set; }
    }
}