using FinalQualification.Data;
using FinalQualification.Data.Repositories.Interfaces.Derived;
using FinalQualification.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualification.Data.Repositories.Classes
{
    public class GamersReviewsRepository : IGamersReviewsRepository
    {
        private readonly DataContext _dataContext;
        public GamersReviewsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(GamerReview gamerReview)
        {
            _dataContext.GamersReviews.Add(gamerReview);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(GamerReview gamerReview)
        {
            _dataContext.GamersReviews.Remove(gamerReview);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<GamerReview>> GetAll()
        {
            return await _dataContext.GamersReviews.ToListAsync();
        }

        public async Task<GamerReview> GetById(long id)
        {
            return await _dataContext.GamersReviews.FirstOrDefaultAsync(gamerReview => gamerReview.Id == id);

        }

        public async Task Update(GamerReview gamerReview)
        {
            _dataContext.GamersReviews.Update(gamerReview);
            await _dataContext.SaveChangesAsync();
        }
    }
}
