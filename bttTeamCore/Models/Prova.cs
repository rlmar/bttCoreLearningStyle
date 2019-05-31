using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bttTeamCore.Models
{
    public class Prova
    {
        public int ID { get; set; }
        [Required]
        public String NomeProva { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataProva { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal PrecoProva { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal PrecoComAlmoco { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal PrecoApenasAlmoco { get; set; }

       
        public virtual ICollection<ProvaCiclEquipa> ProvaCiclEquipas { get; set; }


    }
}
