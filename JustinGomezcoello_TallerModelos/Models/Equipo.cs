using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JustinGomezcoello_TallerModelos.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Ciudad   { get; set; }
        [Range(0,50)]
        public string Titulos { get; set; }
        [MaxLength(2)]
        public string AceptaExtranjeros { get; set; }

        public Estadio Estadio { get; set; }
        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }

    }
}
