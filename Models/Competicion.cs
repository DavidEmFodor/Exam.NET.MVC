using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDavidFodor.Models
{
    public class Competicion
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }

        [MaxLength(150)]
        public string Logo { get; set; }

        [MaxLength(10)]
        public string CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Pais Pais { get; set; }
        public virtual ICollection<CompeticionesEquipos> CompeticionEquipos { get; set; }
    }
}
