using FinalQualificationWork.Data;
using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualificationWork.Data.Repositories.Classes
{
    public class CriticsTextReviewsRepository : ICriticsTextReviewsRepository
    {
        private readonly DataContext _dataContext;
        public CriticsTextReviewsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(CriticTextReview criticTextReview)
        {
            _dataContext.CriticsTextReviews.Add(criticTextReview);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(CriticTextReview criticTextReview)
        {
            _dataContext.CriticsTextReviews.Remove(criticTextReview);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CriticTextReview>> GetAll()
        {
            return await _dataContext.CriticsTextReviews.ToListAsync();
        }

        public async Task<CriticTextReview> GetById(long id)
        {
            return await _dataContext.CriticsTextReviews.FirstOrDefaultAsync(criticTextReview => criticTextReview.Id == id);
        }

        public async Task Update(CriticTextReview criticTextReview)
        {
            _dataContext.CriticsTextReviews.Update(criticTextReview);
            await _dataContext.SaveChangesAsync();
        }
    }
}
