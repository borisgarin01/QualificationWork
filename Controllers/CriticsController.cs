using FinalQualification.Data.Repositories.Interfaces.Derived;
using FinalQualification.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class CriticsController : Controller
    {
        private readonly ICriticsRepository _criticsRepository;

        public CriticsController(ICriticsRepository criticsRepository)
        {
            _criticsRepository = criticsRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _criticsRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Critic critic)
        {
            if (ModelState.IsValid)
            {
                await _criticsRepository.Create(critic);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _criticsRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _criticsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Critic critic)
        {
            if (ModelState.IsValid)
            {
                await _criticsRepository.Update(critic);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _criticsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Critic critic)
        {
            await _criticsRepository.Delete(critic);
            return RedirectToAction("Index");
        }
    }
}
