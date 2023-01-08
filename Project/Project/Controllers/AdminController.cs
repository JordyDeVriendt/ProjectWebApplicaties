using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Areas.Identity.Data;
using Project.Data;
using Project.Models;
using Project.ViewModels;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly ProjectContext _context;
        public AdminController(ProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GamePc()
        {
            ComputerListViewModel viewModel = new ComputerListViewModel();
            viewModel.Computers = await _context.Computers.ToListAsync();
            return View(viewModel);
        }
        public IActionResult GamePcDetails(int? id)
        {
            Computer computer = _context.Computers.Where(c => c.Id == id).FirstOrDefault();
            if (computer != null)
            {
                ComputerDetailsViewModel viewModel = new ComputerDetailsViewModel()
                {
                    Id = computer.Id,
                    Naam = computer.Naam,
                    Afbeelding = computer.Afbeelding,
                    Prijs = computer.Prijs,
                    OperatingSystem = computer.OperatingSystem,
                    CpuCooler = computer.CpuCooler,
                    Behuizing = computer.Behuizing,
                    Opslag = computer.Opslag,
                    Ram = computer.Ram,
                    Moederbord = computer.Moederbord,
                    Cpu = computer.Cpu,
                    Gpu = computer.Cpu
                };
                return View(viewModel);
            }
            else
            {
                ComputerListViewModel viewModel = new ComputerListViewModel()
                {
                    Computers = _context.Computers.ToList()
                };
                return View("index", viewModel);
            }
        }
        [HttpGet]
        public IActionResult GamePcCreate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GamePcCreate(CreateGamePcViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Computer()
                {
                    Naam = viewModel.Naam,
                    Afbeelding = viewModel.Afbeelding,
                    Prijs = viewModel.Prijs,
                    OperatingSystem = viewModel.OperatingSystem,
                    CpuCooler = viewModel.CpuCooler,
                    Behuizing = viewModel.Behuizing,
                    Opslag = viewModel.Opslag,
                    Ram = viewModel.Ram,
                    Moederbord = viewModel.Moederbord,
                    Cpu = viewModel.Cpu,
                    Gpu = viewModel.Gpu,
                });
                await _context.SaveChangesAsync();
                return RedirectToAction("GamePc");
            }
            return View(viewModel);
        }
        public async Task<IActionResult> GamePcDelete(int id)
        {
            Computer computer = _context.Computers.Where(c => c.Id == id).FirstOrDefault();
            if (computer != null)
            {
                _context.Computers.Remove(computer);
                await _context.SaveChangesAsync();
                return RedirectToAction("GamePc");
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("GamePc", _context.Computers.ToList());
        }
        [HttpGet]
        public async Task<IActionResult> GamePcEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computer = await _context.Computers.FindAsync(id);
            if (computer == null)
            {
                return NotFound();
            }

            EditGamePcViewModel viewModel = new EditGamePcViewModel()
            {
                Id = computer.Id,
                Naam = computer.Naam,
                Afbeelding = computer.Afbeelding,
                Prijs = computer.Prijs,
                OperatingSystem = computer.OperatingSystem,
                CpuCooler = computer.CpuCooler,
                Behuizing = computer.Behuizing,
                Opslag = computer.Opslag,
                Ram = computer.Ram,
                Moederbord = computer.Moederbord,
                Cpu = computer.Cpu,
                Gpu = computer.Gpu
            };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GamePcEdit(int id, EditGamePcViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Computer computer = new Computer()
                    {
                        Id = viewModel.Id,
                        Naam = viewModel.Naam,
                        Afbeelding = viewModel.Afbeelding,
                        Prijs = viewModel.Prijs,
                        OperatingSystem = viewModel.OperatingSystem,
                        CpuCooler = viewModel.CpuCooler,
                        Behuizing = viewModel.Behuizing,
                        Opslag = viewModel.Opslag,
                        Ram = viewModel.Ram,
                        Moederbord = viewModel.Moederbord,
                        Cpu = viewModel.Cpu,
                        Gpu = viewModel.Gpu
                    };
                    _context.Update(computer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Computers.Any(e => e.Id == viewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("GamePc");
            }
            return View(viewModel);
        }
    }
}
