using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenDavidFodor.Models;
using System.Linq;

namespace ExamenDavidFodor.Controllers
{
    public class PaisController : Controller
    {
        private readonly ExamenDavidFodorContext _context;

        public PaisController(ExamenDavidFodorContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var paises = _context.Paises.ToList();
            return View(paises);
        }
        public IActionResult Details(string id)
        {
            var pais = _context.Paises
                .Include(p => p.Equipos)
                    .ThenInclude(e => e.CompeticionesEquipos)
                        .ThenInclude(ce => ce.Competicion)
                .FirstOrDefault(p => p.Id == id);

            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }
    }
}
