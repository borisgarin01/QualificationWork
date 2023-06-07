using FinalQualificationWork.Data;
using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualificationWork.Data.Repositories.Classes
{
    public class CriticsVideoReviewsRepository : ICriticsVideoReviewsRepository
    {
        private readonly DataContext _dataContext;
        public CriticsVideoReviewsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(CriticVideoReview criticVideoReview)
        {
            _dataContext.CriticsVideoReviews.Add(criticVideoReview);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(CriticVideoReview criticVideoReview)
        {
            _dataContext.CriticsVideoReviews.Remove(criticVideoReview);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CriticVideoReview>> GetAll()
        {
            return await _dataContext.CriticsVideoReviews.ToListAsync();
        }

        public async Task<CriticVideoReview> GetById(long id)
        {
            return await _dataContext.CriticsVideoReviews.FirstOrDefaultAsync(criticVideoReview => criticVideoReview.Id == id);
        }

        public async Task Update(CriticVideoReview criticVideoReview)
        {
            _dataContext.CriticsVideoReviews.Update(criticVideoReview);
            await _dataContext.SaveChangesAsync();
        }
    }
}
