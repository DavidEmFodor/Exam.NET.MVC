using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDavidFodor.Models
{
    public class CompeticionesEquipos
    {
        [Key]
        public int ID { get; set; }

        public int? CompeticionID { get; set; }
        public int? EquipoID { get; set; }

        [ForeignKey("CompeticionID")]
        public virtual Competicion Competicion { get; set; }

        [ForeignKey("EquipoID")]
        public virtual Equipo Equipo { get; set; }
    }
}
