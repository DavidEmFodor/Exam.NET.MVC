using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDavidFodor.Models
{
    public class Pais
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }

        [Column(TypeName = "nchar")]
        [MaxLength(100)]
        public string CountryName { get; set; }

        [Column(TypeName = "nchar")]
        [MaxLength(150)]
        public string CountryFlag { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<Competicion> Competiciones { get; set; }
    }
}
