using Microsoft.EntityFrameworkCore;
using TunaPiano_BE.Models;
using TunaPiano_BE.Data;
namespace TunaPiano_BE;

public class TunaPiano_BEDbContext : DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Genre> Genres { get; set; }

    public TunaPiano_BEDbContext(DbContextOptions<TunaPiano_BEDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Send data to Songs
        modelBuilder.Entity<Song>().HasData(SongData.Songs);

        // Send data to Artists
        modelBuilder.Entity<Artist>().HasData(ArtistData.Artists);

        // Send data to Genres
        modelBuilder.Entity<Genre>().HasData(GenreData.Genres);
    }
}
