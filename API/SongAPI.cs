using Microsoft.EntityFrameworkCore;
using TunaPiano_BE.Models;
namespace TunaPiano_BE.API;

public class SongAPI
{
    public static void Map(WebApplication app)
    {
        // Get All Songs
        app.MapGet("/api/songs", (TunaPiano_BEDbContext db) =>
        {
            return db.Songs.Select(s => new
            {
                Id = s.Id,
                Title = s.Title,
                ArtistId = s.ArtistId,
                Artist = s.Artist,
                Album = s.Album,
                Length = s.Length,
                Genres = s.Genres,
            });
        });

        // Get Song by Id
        app.MapGet("/api/song/{id}", (TunaPiano_BEDbContext db, int id) =>
        {
            try
            {
                var singleSong = db.Songs.Include(s => s.Artist).Include(s => s.Genres).SingleOrDefault(s => s.Id == id);

                if (singleSong != null)
                {
                    return Results.Ok(singleSong);
                }

                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.NotFound(ex.Message);
            }
        });

        // Create a Song
        app.MapPost("/api/song", (TunaPiano_BEDbContext db, Song song) =>
        {
            db.Songs.Add(song);
            db.SaveChanges();
            return Results.Created($"/api/song/{song.Id}", song);
        });

        // Update a Song
        app.MapPut("/api/song/{id}", (TunaPiano_BEDbContext db, int id, Song songToUpdate) =>
        {
            Song song = db.Songs.SingleOrDefault(s => s.Id == id);

            if (song != null)
            {
                song.Title = songToUpdate.Title ?? song.Title;
                song.ArtistId = songToUpdate.ArtistId != 0 ? songToUpdate.ArtistId : song.ArtistId;
                song.Album = songToUpdate.Album ?? song.Album;
                song.Length = songToUpdate.Length != 0 ? songToUpdate.Length : song.Length;

                db.SaveChanges();
                return Results.NoContent();
            }

            return Results.NotFound();
        });

        // Delete a Song
        app.MapDelete("/api/song/{id}", (TunaPiano_BEDbContext db, int id) =>
        {
            Song song = db.Songs.SingleOrDefault(s => s.Id == id);

            if (song == null)
            {
                return Results.NotFound();
            }

            db.Songs.Remove(song);
            db.SaveChanges();

            return Results.NoContent();
        });
	}
}

