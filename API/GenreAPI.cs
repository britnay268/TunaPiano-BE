using TunaPiano_BE.Models;
namespace TunaPiano_BE.API;

public class GenreAPI
{
	public static void Map(WebApplication app)
	{
        // Get All Genres
        app.MapGet("/api/genres", (TunaPiano_BEDbContext db) =>
        {
            return db.Genres.Select(g => new
            {
                Id = g.Id,
                Description = g.Description,
            });
        });

        // Get Genre by Id
        app.MapGet("/api/genre/{id}", (TunaPiano_BEDbContext db, int id) =>
        {
            var singleGenre = db.Genres.Select(g => new
            {
                Id = g.Id,
                Description = g.Description,
                Songs = g.Songs.Select(s => new
                {
                    Id = s.Id,
                    Title = s.Title,
                    ArtistId = s.ArtistId,
                    Artist = s.Artist,
                    Album = s.Album,
                    Length = s.Length,
                })
            }).SingleOrDefault(g => g.Id == id);

            if (singleGenre != null)
            {
                return Results.Ok(singleGenre);
            }

            return Results.NotFound();
        });

        // Create a Genre
        app.MapPost("/api/genre", (TunaPiano_BEDbContext db, Genre genre) =>
        {
            db.Genres.Add(genre);
            db.SaveChanges();
            return Results.Created($"/api/genre/{genre.Id}", genre);
        });

        // Update a Genre
        app.MapPut("/api/genre/{id}", (TunaPiano_BEDbContext db, int id, Genre genreToUpdate) =>
        {
            Genre genre = db.Genres.SingleOrDefault(g => g.Id == id);

            if (genre != null)
            {
                genre.Description = genreToUpdate.Description ?? genre.Description;

                db.SaveChanges();
                return Results.NoContent();
            }

            return Results.NotFound();
        });

        // Delete a Genre
        app.MapDelete("/api/genre/{id}", (TunaPiano_BEDbContext db, int id) =>
        {
            Genre genreToDelete = db.Genres.SingleOrDefault(g => g.Id == id);

            if (genreToDelete == null)
            {
                return Results.NotFound();
            }

            db.Genres.Remove(genreToDelete);
            db.SaveChanges();

            return Results.NoContent();
        });
    }
}

