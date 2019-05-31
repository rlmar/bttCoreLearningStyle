using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bttTeamCore.Models
{
    public class ProvaCiclEquipa
    {
        public int ID { get; set; }



        public int ProvaId { get; set; }
        public virtual Prova Prova { get; set; }


        public int CiclistaId { get; set; }
        public virtual Ciclista Ciclista { get; set; }

        public int? EquipaID { get; set; }
        public virtual Equipa Equipa { get; set; }

        /* [Required]
        public String Percurso { get; set; }
        */

        [Required]
        public bool Almoco { get; set; }
        [Required]
        public int NumAcompanhantes { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal? ValorPagamento { get; set; }
        [Required]
        public bool Pago { get; set; }
        public int? Dorsal { get; set; }
      

        public TimeSpan? Tempo { get; set; }
        public int? Classificacao { get; set; }

        public Percurso Percursos { get; set; }


       
        public enum Percurso
        {
            [Display(Name = "Passeio (25 Km)")]
            Passeio = 25,

            [Display(Name = "Raid (40 Km)")]
            Raid = 40

        }

    }
}
