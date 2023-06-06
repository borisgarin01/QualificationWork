using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class GamersReviewsController : Controller
    {
        private readonly IGamersReviewsRepository _gamersReviewsRepository;

        public GamersReviewsController(IGamersReviewsRepository gamersReviewsRepository)
        {
            _gamersReviewsRepository = gamersReviewsRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GamerReview gamerReview)
        {
            if(ModelState.IsValid)
            {
                await _gamersReviewsRepository.Create(gamerReview);
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _gamersReviewsRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _gamersReviewsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(GamerReview gamerReview)
        {
            if (ModelState.IsValid)
            {
                await _gamersReviewsRepository.Update(gamerReview);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _gamersReviewsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(GamerReview gamerReview)
        {
            await _gamersReviewsRepository.Delete(gamerReview);
            return RedirectToAction("Index");
        }
    }
}
