using FinalQualificationWork.Data;
using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualificationWork.Data.Repositories.Classes
{
    public class GamesRepository : IGamesRepository
    {
        private readonly DataContext _dataContext;
        public GamesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(Game game)
        {
            _dataContext.Games.Add(game);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(Game game)
        {
            _dataContext.Games.Remove(game);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await _dataContext.Games.ToListAsync();
        }

        public async Task<Game> GetById(long id)
        {
            return await _dataContext.Games.FirstOrDefaultAsync(game => game.Id == id);
        }

        public async Task Update(Game game)
        {
            _dataContext.Games.Update(game);
            await _dataContext.SaveChangesAsync();
        }
    }
}
