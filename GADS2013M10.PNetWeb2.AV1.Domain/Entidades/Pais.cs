using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADS2013M10.PNetWeb2.AV1.Domain.Entidades
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Serie> Series { get; set; }
    }
}
