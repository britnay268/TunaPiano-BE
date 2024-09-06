using TunaPiano_BE.Models;
namespace TunaPiano_BE.Data;

public class ArtistData
{
	public static List<Artist> Artists = new List<Artist>
	{
        new Artist
        {
            Id = 1,
            Name = "Burna Boy",
            Age = 32,
            Bio = "Nigerian singer and songwriter known for his fusion of Afrobeat and other genres"
        },
        new Artist
        {
            Id = 1,
            Name = "Tems",
            Age = 27,
            Bio = "Nigerian singer and songwriter known for her soulful voice and introspective lyrics"
        },
        new Artist
        {
            Id = 3,
            Name = "David Guetta",
            Age = 55,
            Bio = "French DJ and record producer known for EDM hits"
        },
        new Artist
        {
            Id = 4,
            Name = "Martin Garrix",
            Age = 27,
            Bio = "Dutch DJ and record producer known for his EDM tracks"
        },
        new Artist
        {
            Id = 5,
            Name = "Miles Davis",
            Age = 40,
            Bio = "Legendary jazz trumpeter and composer"
        },
        new Artist
        {
            Id = 6,
            Name = "John Coltrane",
            Age = 42,
            Bio = "Saxophonist known for his innovative jazz playing"
        },
        new Artist
        {
            Id = 7, Name = "Kirk Franklin",
            Age = 55,
            Bio = "Grammy-winning gospel singer and producer"
        },
        new Artist
        {
            Id = 8,
            Name = "Tasha Cobbs Leonard",
            Age = 40,
            Bio = "Gospel singer known for her powerful vocals"
        }
    };
}

