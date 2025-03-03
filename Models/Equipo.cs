using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDavidFodor.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }
        public int? Founded { get; set; }

        [MaxLength(150)]
        public string Logo { get; set; }

        [MaxLength(10)]
        public string PaisId { get; set; }

        [ForeignKey("PaisId")]
        public virtual Pais Pais { get; set; }
        public virtual ICollection<CompeticionesEquipos> CompeticionesEquipos { get; set; }
    }
}
