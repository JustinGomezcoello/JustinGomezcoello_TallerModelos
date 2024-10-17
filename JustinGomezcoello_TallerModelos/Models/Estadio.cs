using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JustinGomezcoello_TallerModelos.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [NotNull]
        public string Ciudad { get; set; }
        public string? Capacidad { get; set; }
    }
}
