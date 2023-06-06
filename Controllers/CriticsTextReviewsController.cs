using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalQualifyingWork.Controllers
{
    public class CriticsTextReviewsController:Controller
    {
        private readonly ICriticsTextReviewsRepository _criticsTextReviewsRepository;
        public CriticsTextReviewsController(ICriticsTextReviewsRepository criticsTextReviewsRepository)
        {
            _criticsTextReviewsRepository = criticsTextReviewsRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _criticsTextReviewsRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CriticTextReview criticTextReview)
        {
            if (ModelState.IsValid)
            {
                await _criticsTextReviewsRepository.Create(criticTextReview);
                return RedirectToAction("Index");
            }
            return View(criticTextReview);
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _criticsTextReviewsRepository.GetById(id));
        }

        public async Task<IActionResult> Update(long id)
        {
            return View(await _criticsTextReviewsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CriticTextReview criticTextReview)
        {
            if (ModelState.IsValid)
            {
                await _criticsTextReviewsRepository.Update(criticTextReview);
                return RedirectToAction("Index");
            }
            return View(criticTextReview);
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _criticsTextReviewsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CriticTextReview criticTextReview)
        {
            await _criticsTextReviewsRepository.Delete(criticTextReview);
            return RedirectToAction("Index");
        }
    }
}
