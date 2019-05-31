using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bttTeamCore.Models
{
    public class Equipa
    {
        public int ID { get; set; }
        [Required]
        public String NomeEquipa { get; set; }
        [Required]
        public String Localidade { get; set; }

        public virtual ICollection<ProvaCiclEquipa> ProvaCiclEquipas { get; set; }

    }
}
