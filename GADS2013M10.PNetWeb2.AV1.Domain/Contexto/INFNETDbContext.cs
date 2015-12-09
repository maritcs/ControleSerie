using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;

namespace GADS2013M10.PNetWeb2.AV1.Domain.Contexto
{
    public class INFNETDbContext : DbContext
    {
        public DbSet<CanalTv> CanaisTv { get; set; }
        public DbSet<Episodio> Episodios { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Temporada> Temporadas { get; set; }
    }
}
