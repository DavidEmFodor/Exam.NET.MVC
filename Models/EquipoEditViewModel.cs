using System.Collections.Generic;

namespace ExamenDavidFodor.Models
{
    public class EquipoEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? Founded { get; set; }
        public string Logo { get; set; }
        public string PaisId { get; set; }
        public List<int> SelectedCompetitions { get; set; } = new List<int>();
    }
}
