using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
using Project.ViewModels;
using System.Linq;

namespace Project.Controllers
{
    public class AanbodController : Controller
    {
        private readonly ProjectContext _context;
        public AanbodController(ProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GamePc()
        {
            ComputerListViewModel viewModel = new ComputerListViewModel();
            viewModel.Computers = _context.Computers.ToList();
            return View(viewModel);
        }
        public IActionResult GamingLaptops()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            Computer computer = _context.Computers.Where(p => p.Id == id).FirstOrDefault();
            if (computer != null)
            {
                ComputerDetailsViewModel viewModel = new ComputerDetailsViewModel()
                {
                    Naam = computer.Naam,
                    Prijs = computer.Prijs,
                    OperatingSystem = computer.OperatingSystem,
                    CpuCooler = computer.CpuCooler,
                    Behuizing = computer.Behuizing,
                    Ram= computer.Ram,
                    Opslag= computer.Opslag,
                    Moederbord = computer.Moederbord,
                };
                return View(viewModel);
            }
            else
            {
                ComputerListViewModel viewModel = new ComputerListViewModel();
                viewModel.Computers = _context.Computers.ToList();
                return View("", viewModel);
            }
        }
    }
}
