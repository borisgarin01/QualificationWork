using FinalQualification.Data;
using FinalQualification.Data.Repositories.Interfaces.Derived;
using FinalQualification.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualification.Data.Repositories.Classes
{
    public class GenresRepository : IGenresRepository
    {
        private readonly DataContext _dataContext;
        public GenresRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(Genre entity)
        {
            _dataContext.Genres.Add(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(Genre entity)
        {
            _dataContext.Genres.Add(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            return await _dataContext.Genres.ToListAsync();
        }

        public async Task<Genre> GetById(long id)
        {
            return await _dataContext.Genres.FirstOrDefaultAsync(genre => genre.Id == id);
        }

        public async Task Update(Genre entity)
        {
            _dataContext.Genres.Update(entity);
            await _dataContext.SaveChangesAsync();
        }
    }
}
