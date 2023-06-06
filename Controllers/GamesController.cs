using FinalQualification.Data.Repositories.Interfaces.Derived;
using FinalQualification.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGamesRepository _gamesRepository;

        public GamesController(IGamesRepository gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Game game)
        {
            if (ModelState.IsValid)
            {
                await _gamesRepository.Create(game);
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _gamesRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _gamesRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                await _gamesRepository.Update(game);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _gamesRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Game game)
        {
            await _gamesRepository.Delete(game);
            return RedirectToAction("Index");
        }
    }
}
