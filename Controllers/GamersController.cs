using FinalQualification.Data.Repositories.Interfaces.Derived;
using FinalQualification.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class GamersController : Controller
    {
        private readonly IGamersRepository _gamersRepository;

        public GamersController(IGamersRepository gamersRepository)
        {
            _gamersRepository = gamersRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _gamersRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Gamer gamer)
        {
            if (ModelState.IsValid)
            {
                await _gamersRepository.Create(gamer);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _gamersRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _gamersRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Gamer gamer)
        {
            if (ModelState.IsValid)
            {
                await _gamersRepository.Update(gamer);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _gamersRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Gamer gamer)
        {
            await _gamersRepository.Delete(gamer);
            return RedirectToAction("Index");
        }
    }
}
