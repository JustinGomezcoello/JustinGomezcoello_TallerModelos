﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustinGomezcoello_TallerModelos.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Posicion { get; set; }
        [Range(0,60)]
        public string Edad { get; set; }
        public Equipo? Equipo { get; set; } 
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }

    }
}
