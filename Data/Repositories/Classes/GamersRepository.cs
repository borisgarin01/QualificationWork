using FinalQualificationWork.Data;
using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualificationWork.Data.Repositories.Classes
{
    public class GamersRepository : IGamersRepository
    {
        private readonly DataContext _dataContext;
        public GamersRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(Gamer gamer)
        {
            _dataContext.Gamers.Add(gamer);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(Gamer gamer)
        {
            _dataContext.Gamers.Remove(gamer);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Gamer>> GetAll()
        {
            return await _dataContext.Gamers.ToListAsync();
        }

        public async Task<Gamer> GetById(long id)
        {
            return await _dataContext.Gamers.FirstOrDefaultAsync(gamer => gamer.Id == id);
        }

        public async Task Update(Gamer gamer)
        {
            _dataContext.Gamers.Update(gamer);
            await _dataContext.SaveChangesAsync();
        }
    }
}
