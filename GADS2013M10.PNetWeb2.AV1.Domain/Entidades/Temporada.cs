using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GADS2013M10.PNetWeb2.AV1.Domain.Entidades
{
    public class Temporada
    {
        public int TemporadaId { get; set; }

        [Display(Name = "Número da Temporada")]
        public string NumTemp { get; set; }
       

        public virtual ICollection<Serie> Series { get; set; }
    }
}
