using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;

namespace FinalQualifyingWork.Controllers
{
    public class CriticsVideoReviewsController : Controller
    {
        private readonly ICriticsVideoReviewsRepository _criticsVideoReviewsRepository;

        public CriticsVideoReviewsController(ICriticsVideoReviewsRepository criticsVideoReviewsRepository)
        {
            _criticsVideoReviewsRepository = criticsVideoReviewsRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _criticsVideoReviewsRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CriticVideoReview criticVideoReview)
        {
            if (ModelState.IsValid)
            {
                await _criticsVideoReviewsRepository.Create(criticVideoReview);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Get(long id)
        {
            return View(await _criticsVideoReviewsRepository.GetById(id));
        }

        public async Task<IActionResult> Edit(long id)
        {
            return View(await _criticsVideoReviewsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CriticVideoReview criticVideoReview)
        {
            if (ModelState.IsValid)
            {
                await _criticsVideoReviewsRepository.Update(criticVideoReview);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            return View(await _criticsVideoReviewsRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CriticVideoReview criticVideoReview)
        {
            await _criticsVideoReviewsRepository.Delete(criticVideoReview);
            return RedirectToAction("Index");
        }
    }
}

