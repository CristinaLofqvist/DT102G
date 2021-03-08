using DT102G_Moment_3_3.Models;
using Microsoft.EntityFrameworkCore;

namespace DT102G_Moment_3_3.Data
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options)
        {
        }
        public DbSet<Track> Tracks { get; set; }
    }
}

