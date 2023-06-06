using System.ComponentModel.DataAnnotations;

namespace WorldDominion.Models
{
    public enum ProductWeightUnit
    {
        Grams,
        Kilograms,
        Pounds,
        Ounces,
        Litres
    }

    public class Product
    {
        public int Id { get; set; }

        [Required()]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Required()]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Product Description")]
        public string? Description { get; set; }

        [Required(), Range(0.01, 999999.99)]
        public double MSRP { get; set; }

        [Required(), Range(0.01, 999999.99)]
        public decimal Weight { get; set; }

        [Required()]
        public ProductWeightUnit WeightUnit { get; set; }

        public string? Photo { get; set; }

        public Department? Department { get; set; }
    }
}
