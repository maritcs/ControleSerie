using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace GADS2013M10.PNetWeb2.AV1.Domain.Entidades
{
    public class CanalTv
    {
        public int CanalTvId { get; set; }

        [Display(Name = "Nome do Canal")]
        public string NomeCanal { get; set; }

        public virtual ICollection<Serie> Series { get; set; }
    }
}
