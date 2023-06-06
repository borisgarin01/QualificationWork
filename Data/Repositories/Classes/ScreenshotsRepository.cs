using FinalQualification.Data;
using FinalQualification.Data.Repositories.Interfaces.Derived;
using FinalQualification.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualification.Data.Repositories.Classes
{
    public class ScreenshotsRepository : IScreenshotsRepository
    {
        private readonly DataContext _dataContext;
        public ScreenshotsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(Screenshot screenshot)
        {
            _dataContext.Screenshots.Add(screenshot);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(Screenshot screenshot)
        {
            _dataContext.Screenshots.Remove(screenshot);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Screenshot>> GetAll()
        {
            return await _dataContext.Screenshots.ToListAsync();
        }

        public async Task<Screenshot> GetById(long id)
        {
            return await _dataContext.Screenshots.FirstOrDefaultAsync(screenshot => screenshot.Id == id);
        }

        public async Task Update(Screenshot screenshot)
        {
            _dataContext.Screenshots.Update(screenshot);
            await _dataContext.SaveChangesAsync();
        }
    }
}
