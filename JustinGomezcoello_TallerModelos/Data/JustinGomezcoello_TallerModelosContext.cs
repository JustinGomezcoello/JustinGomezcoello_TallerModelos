using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JustinGomezcoello_TallerModelos.Models;

namespace JustinGomezcoello_TallerModelos.Data
{
    public class JustinGomezcoello_TallerModelosContext : DbContext
    {
        public JustinGomezcoello_TallerModelosContext (DbContextOptions<JustinGomezcoello_TallerModelosContext> options)
            : base(options)
        {
        }

        public DbSet<JustinGomezcoello_TallerModelos.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<JustinGomezcoello_TallerModelos.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<JustinGomezcoello_TallerModelos.Models.Estadio> Estadio { get; set; } = default!;
    }
}
