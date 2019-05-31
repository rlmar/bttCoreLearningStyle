using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bttTeamCore.Models
{
    public class Foto
    {
        public int ID { get; set; }
        [Required]
        public String NomeFoto { get; set; }

        [StringLength(255)]
        public String Descricao { get; set; }
        

        public bool Visivel { get; set; }

        public int CiclistaId { get; set; }
        public virtual Ciclista Ciclista { get; set; }

        public int ProvaId { get; set; }
        public virtual Prova Prova { get; set; }
    }
}
