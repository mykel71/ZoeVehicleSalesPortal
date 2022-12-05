using SalesPortal.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesPortal.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageURL { get; set; }
        public CarCategory CarCategory { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //Relationships
        public List<Model_Car> Models_Cars { get; set; }
        //Make
        public int MakeId { get; set; }
        [ForeignKey("MakeId")]
        public Make Make { get; set; }
    }
}
