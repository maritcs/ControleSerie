using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GADS2013M10.PNetWeb2.AV1.Domain.Entidades
{
    public class Serie
    {
        public int SerieId { get; set; }

        [Display(Name="Nome da Série")]
        public string NomeSerie { get; set; }

        public string Criador { get; set; }

        [Display(Name = "Sinopse da Temporada")]
        public string SinopseTemporada { get; set; }

        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Foto da Capa")]
        public byte[] FotoCapa { get; set; }

        [Display(Name = "Sinopse do Episódio")]
        public string SinopseEpisodio { get; set; }

        [Display(Name = "Data em que o Episódio foi ao ar")]
        public DateTime DataEpAr { get; set; }

        [Display(Name = "Duração")]
        public string Duracao { get; set; }

        public bool Download { get; set; }
        public bool Assitido { get; set; }

        [Display(Name = "Caminho do Arquivo")]
        public string CaminhoArq { get; set; }

        [Display(Name = "Tipo do Arquivo")]
        public string TipoArq { get; set; }

        public bool Legenda { get; set; }
        
        public StatusSerie Status { get; set; }

        [Display(Name = "País")]
        public int PaisId { get; set; }

        [Display(Name = "Gênero")]
        public int GeneroId { get; set; }

        [Display(Name = "Episódio")]
        public int EpisodioId { get; set; }

        [Display(Name = "Temporada")]
        public int TemporadaId { get; set; }

        [Display(Name = "Canal da Tv")]
        public int CanalTvId { get; set; }


        // Propriedade de navegação
        // Virtual também por causa do Entity Framework
        public virtual Genero Generos { get; set; }
        public virtual Pais Paises { get; set; }
        public virtual Episodio Episodios { get; set; }
        public virtual Temporada Temporadas { get; set; }
        public virtual CanalTv CanaisTv { get; set; }

        public enum StatusSerie
        {
            [Display(Name="Em Produção")]
            EmProducao,

            Suspensa,
            Finalizada,
            Piloto
        }
   

      
    }
}
