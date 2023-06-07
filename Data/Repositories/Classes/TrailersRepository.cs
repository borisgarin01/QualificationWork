using FinalQualificationWork.Data;
using FinalQualificationWork.Data.Repositories.Interfaces.Derived;
using FinalQualificationWork.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualificationWork.Data.Repositories.Classes
{
    public class TrailersRepository : ITrailersRepository
    {
        private readonly DataContext _dataContext;
        public TrailersRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Create(Trailer trailer)
        {
            _dataContext.Trailers.Add(trailer);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(Trailer trailer)
        {
            _dataContext.Trailers.Remove(trailer);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Trailer>> GetAll()
        {
            return await _dataContext.Trailers.ToListAsync();
        }

        public async Task<Trailer> GetById(long id)
        {
            return await _dataContext.Trailers.FirstOrDefaultAsync(trailer => trailer.Id == id);
        }

        public async Task Update(Trailer trailer)
        {
            _dataContext.Trailers.Update(trailer);
            await _dataContext.SaveChangesAsync();
        }
    }
}
