using System.ComponentModel.DataAnnotations;

namespace RestauranteAPI.Models
{
    public class Product
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin {get; set; }
    }
}
