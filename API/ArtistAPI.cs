using TunaPiano_BE.Models;
namespace TunaPiano_BE.API;

public class ArtistAPI
{
	public static void Map(WebApplication app)
	{
		// Get All Artists
		app.MapGet("/api/artists", (TunaPiano_BEDbContext db) =>
		{
			return db.Artists.Select(a => new
			{
				Id = a.Id,
				Name = a.Name,
				Age = a.Age,
				Bio = a.Bio,
				Songs = a.Songs
			});
		});

		// Get Artist by Id
		app.MapGet("/api/artist/{id}", (TunaPiano_BEDbContext db, int id) =>
		{
			var singleArtist = db.Artists.Select(a => new
			{
                Id = a.Id,
                Name = a.Name,
                Age = a.Age,
                Bio = a.Bio,
                Songs = a.Songs
            }).SingleOrDefault(a => a.Id == id);

			if (singleArtist == null)
			{
				return Results.NotFound();
			}

			return Results.Ok(singleArtist);
		});

		// Create an Artist
		app.MapPost("/api/artist", (TunaPiano_BEDbContext db, Artist newArtist) =>
		{
			db.Artists.Add(newArtist);
			db.SaveChanges();
			return Results.Created($"/api/artist/{newArtist.Id}", newArtist);
		});

		// Update an Artist
		app.MapPut("/api/artist/{id}", (TunaPiano_BEDbContext db, int id, Artist artistToUpdate) =>
		{
			Artist artist = db.Artists.SingleOrDefault(a => a.Id == id);

			if (artist == null)
			{
				return Results.NotFound();
			}

			artist.Name = artistToUpdate.Name ?? artist.Name; // Update only if Name has a value
			artist.Age = artistToUpdate.Age != 0 ? artistToUpdate.Age : artist.Age; //Update only if Age has a non-zero value
            artist.Bio = artistToUpdate.Bio ?? artist.Bio;

			db.SaveChanges();

			return Results.NoContent();
        });

		// Delete an Artist
		app.MapDelete("/api/artist/{id}", (TunaPiano_BEDbContext db, int id) =>
		{
			Artist artistToDelete = db.Artists.SingleOrDefault(a => a.Id == id);

			if (artistToDelete == null)
			{
				return Results.NotFound();
			}

			db.Artists.Remove(artistToDelete);
			db.SaveChanges();

			return Results.NoContent();
        });
	}
}

