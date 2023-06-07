using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class ScreenshotsController : Controller
    {
        private readonly IScreenshotsRepository _screenshotsRepository;

        public ScreenshotsController(IScreenshotsRepository screenshotsRepository)
        {
            _screenshotsRepository = screenshotsRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Screenshot screenshot)
        {
            if (ModelState.IsValid)
            {
                await _screenshotsRepository.Create(screenshot);
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _screenshotsRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _screenshotsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Screenshot screenshot)
        {
            if (ModelState.IsValid)
            {
                await _screenshotsRepository.Update(screenshot);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _screenshotsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Screenshot screenshot)
        {
            await _screenshotsRepository.Delete(screenshot);
            return RedirectToAction("Index");
        }
    }
}
