using System.ComponentModel.DataAnnotations;

namespace TareaVehiculo.Entities
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Marca { get; set; }

        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }

        public string Color { get; set; }

        public int Kilometraje { get; set; }
    }
}
