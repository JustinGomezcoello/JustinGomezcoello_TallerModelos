using System.ComponentModel.DataAnnotations;

namespace JustinGomezcoello_TallerModelos.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Dirección")]//hfhg
        public string Direccion { get; set; }
        
        public string Ciudad { get; set; }
        public string Capacidad { get; set; }
    }
}
