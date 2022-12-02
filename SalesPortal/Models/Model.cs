using System.ComponentModel.DataAnnotations;

namespace SalesPortal.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Picture is required")]
        public string PictureURL { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Model_Car> Models_Cars { get; set; }
    }
}
