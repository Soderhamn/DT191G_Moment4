using MusicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicApi.Data {
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options) {

        }

        public DbSet<Song> Songs { get; set; }
    }
}