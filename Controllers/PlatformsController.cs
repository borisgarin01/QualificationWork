using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class PlatformsController:Controller
    {
        private readonly IPlatformsRepository _platformsRepository;

        public PlatformsController(IPlatformsRepository platformsRepository)
        {
            _platformsRepository = platformsRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Platform platform)
        {
            if (ModelState.IsValid)
            {
                await _platformsRepository.Create(platform);
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _platformsRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _platformsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Platform platform)
        {
            if (ModelState.IsValid)
            {
                await _platformsRepository.Update(platform);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _platformsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Platform platform)
        {
            await _platformsRepository.Delete(platform);
            return RedirectToAction("Index");
        }
    }
}
