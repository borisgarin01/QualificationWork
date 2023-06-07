using FinalQualificationWork.Data;
using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualificationWork.Data.Repositories.Classes
{
    public class PlatformsRepository : IPlatformsRepository
    {
        private readonly DataContext _dataContext;
        public PlatformsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(Platform entity)
        {
            _dataContext.Platforms.Add(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(Platform entity)
        {
            _dataContext.Platforms.Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Platform>> GetAll()
        {
            return await _dataContext.Platforms.ToListAsync();
        }

        public async Task<Platform> GetById(long id)
        {
            return await _dataContext.Platforms.FirstOrDefaultAsync(platform => platform.Id == id);
        }

        public async Task Update(Platform entity)
        {
            _dataContext.Platforms.Update(entity);
            await _dataContext.SaveChangesAsync();
        }
    }
}
