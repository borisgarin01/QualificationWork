using FinalQualification.Data;
using FinalQualification.Data.Repositories.Interfaces.Derived;
using FinalQualification.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualification.Data.Repositories.Classes
{
    public class CriticsRepository : ICriticsRepository
    {
        private readonly DataContext _dataContext;
        public CriticsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(Critic critic)
        {
            _dataContext.Critics.Add(critic);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(Critic critic)
        {
            _dataContext.Critics.Remove(critic);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Critic>> GetAll()
        {
            return await _dataContext.Critics.ToListAsync();
        }

        public async Task<Critic> GetById(long id)
        {
            return await _dataContext.Critics.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(Critic critic)
        {
            _dataContext.Critics.Update(critic);
            await _dataContext.SaveChangesAsync();
        }
    }
}
