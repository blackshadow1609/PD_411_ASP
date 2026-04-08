using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage = "ID is required")]
        public int student_id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        [Display(Name = "First Name")]
        public string? first_name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        [Display(Name = "Last Name")]
        public string? last_name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string? email { get; set; }

        [Display(Name = "Group")]
        public int? group_id { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime? enrollment_date { get; set; }

        // Navigation property
        public Group? Group { get; set; }
    }
}