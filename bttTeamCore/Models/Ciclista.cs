using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bttTeamCore.Models
{
    public class Ciclista
    {
        public int ID { get; set; }

        [Required]
        public String Nome { get; set; }
        [Required]
        public String Telemovel { get; set; }
        [Required]
        public String Mail { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required]
        public String BI { get; set; }
        [Required]
        public String Localidade { get; set; }


        public virtual ICollection<ProvaCiclEquipa> ProvaCiclEquipas { get; set; }

        public virtual ICollection<Foto> Fotos { get; set; }


    }
}
