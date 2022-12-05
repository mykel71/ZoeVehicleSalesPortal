using System.ComponentModel.DataAnnotations;

namespace SalesPortal.Models
{
    public class Make
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string? LogoURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string? Bio { get; set; }

        //Relationships
        public List<Car> Cars { get; set; }
    }
}
