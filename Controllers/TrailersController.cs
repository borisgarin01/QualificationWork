using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class TrailersController : Controller
    {
        private readonly ITrailersRepository _trailersRepository;

        public TrailersController(ITrailersRepository trailersRepository)
        {
            _trailersRepository = trailersRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Trailer trailer)
        {
            if (ModelState.IsValid)
            {
                await _trailersRepository.Create(trailer);
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _trailersRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _trailersRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Trailer trailer)
        {
            if (ModelState.IsValid)
            {
                await _trailersRepository.Update(trailer);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _trailersRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Trailer trailer)
        {
            await _trailersRepository.Delete(trailer);
            return RedirectToAction("Index");
        }
    }
}
