using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenDavidFodor.Models;
using System.Linq;

namespace ExamenDavidFodor.Controllers
{
    public class EquipoController : Controller
    {
        private readonly ExamenDavidFodorContext _context;

        public EquipoController(ExamenDavidFodorContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var equipos = _context.Equipos
                .Include(e => e.Pais)
                .Include(e => e.CompeticionesEquipos)
                    .ThenInclude(ce => ce.Competicion)
                .ToList();
            return View(equipos);
        }
        public IActionResult Edit(int id)
        {
            var equipo = _context.Equipos
                .Include(e => e.CompeticionesEquipos)
                .FirstOrDefault(e => e.Id == id);

            if (equipo == null)
            {
                return NotFound();
            }
            var viewModel = new EquipoEditViewModel
            {
                Id = equipo.Id,
                Name = equipo.Name,
                Code = equipo.Code,
                Founded = equipo.Founded,
                Logo = equipo.Logo,
                PaisId = equipo.PaisId,
                SelectedCompetitions = equipo.CompeticionesEquipos
                    .Where(ce => ce.CompeticionID.HasValue)
                    .Select(ce => ce.CompeticionID.Value)
                    .ToList()
            };

            ViewBag.Paises = new SelectList(_context.Paises, "Id", "CountryName", equipo.PaisId);
            ViewBag.Competitions = new MultiSelectList(_context.Competiciones, "Id", "Name", viewModel.SelectedCompetitions);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EquipoEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Paises = new SelectList(_context.Paises, "Id", "CountryName", viewModel.PaisId);
                ViewBag.Competitions = new MultiSelectList(_context.Competiciones, "Id", "Name", viewModel.SelectedCompetitions);
                return View(viewModel);
            }

            var equipo = _context.Equipos
                .Include(e => e.CompeticionesEquipos)
                .FirstOrDefault(e => e.Id == viewModel.Id);

            if (equipo == null)
            {
                return NotFound();
            }

            equipo.Name = viewModel.Name;
            equipo.Code = viewModel.Code;
            equipo.Founded = viewModel.Founded;
            equipo.Logo = viewModel.Logo;
            equipo.PaisId = viewModel.PaisId;
            _context.CompeticionesEquipos.RemoveRange(equipo.CompeticionesEquipos);
            if (viewModel.SelectedCompetitions != null)
            {
                foreach (var compId in viewModel.SelectedCompetitions)
                {
                    _context.CompeticionesEquipos.Add(new CompeticionesEquipos
                    {
                        CompeticionID = compId,
                        EquipoID = equipo.Id
                    });
                }
            }

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
