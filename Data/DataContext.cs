using FinalQualificationWork.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FinalQualificationWork.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Critic> Critics { get; set; }
        public DbSet<CriticTextReview> CriticsTextReviews { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<GamerReview> GamersReviews { get; set; }
        public DbSet<Screenshot> Screenshots { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<CriticVideoReview> CriticsVideoReviews { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Platform> Platforms { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
