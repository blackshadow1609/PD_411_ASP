using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Teacher
    {
        [Key]
        [Required(ErrorMessage = "ID is required")]
        [Display(Name = "Teacher ID")]
        public short teacher_id { get; set; }

        [StringLength(50, ErrorMessage = "Last name must be less than 50 characters")]
        [Display(Name = "Last Name")]
        public string? last_name { get; set; }

        [StringLength(50, ErrorMessage = "First name must be less than 50 characters")]
        [Display(Name = "First Name")]
        public string? first_name { get; set; }

        [StringLength(50, ErrorMessage = "Middle name must be less than 50 characters")]
        [Display(Name = "Middle Name")]
        public string? middle_name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime? birth_date { get; set; }

        [StringLength(50, ErrorMessage = "Email must be less than 50 characters")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string? email { get; set; }

        [StringLength(16, ErrorMessage = "Phone must be less than 16 characters")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone")]
        public string? phone { get; set; }

        [Display(Name = "Photo")]
        public byte[]? photo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Work Since")]
        public DateTime? work_since { get; set; }

        [Display(Name = "Rate")]
        public decimal? rate { get; set; }
    }
}