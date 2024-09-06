using TunaPiano_BE.Models;
namespace TunaPiano_BE.Data;

public class SongData
{
	public List<Song> Songs = new List<Song>()
	{
        new Song
        {
            Id = 1,
            Title = "Last Last",
            ArtistId = 1,
            Album = "Love, Damini",
            Length = 240.5,
            Genres = new List<Genre> { GenreData.Genres[0] }
        },
        new Song
        {
            Id = 2,
            Title = "Free Mind",
            ArtistId = 2,
            Album = "If Orange Was the Color of Sky",
            Length = 210.2,
            Genres = new List<Genre> { GenreData.Genres[0] }
        },
        new Song
        {
            Id = 3,
            Title = "Play Hard",
            ArtistId = 3,
            Album = "Nothing But the Beat",
            Length = 270.8,
            Genres = new List<Genre> { GenreData.Genres[1] }
        },
        new Song
        {
            Id = 4,
            Title = "Animals",
            ArtistId = 4,
            Album = "Animals",
            Length = 255.3,
            Genres = new List<Genre> { GenreData.Genres[1] }
        },
        new Song
        {
            Id = 5,
            Title = "So What",
            ArtistId = 5,
            Album = "Kind of Blue",
            Length = 300.0,
            Genres = new List<Genre> { GenreData.Genres[2] }
        },
        new Song
        {
            Id = 6,
            Title = "Giant Steps",
            ArtistId = 6,
            Album = "Giant Steps",
            Length = 285.7,
            Genres = new List<Genre> { GenreData.Genres[2] }
        },
        new Song
        {
            Id = 7,
            Title = "Stomp",
            ArtistId = 7,
            Album = "The Rebirth",
            Length = 220.1,
            Genres = new List<Genre> { GenreData.Genres[3] }
        },
        new Song
        {
            Id = 8,
            Title = "Break Every Chain",
            ArtistId = 8,
            Album = "Grace",
            Length = 235.6,
            Genres = new List<Genre> { GenreData.Genres[3] }
        },
        new Song
        {
            Id = 9,
            Title = "Ye",
            ArtistId = 1,
            Album = "Twice as Tall",
            Length = 260.9,
            Genres = new List<Genre> { GenreData.Genres[0] }
        },
        new Song
        {
            Id = 10,
            Title = "Vibez",
            ArtistId = 2,
            Album = "If Orange Was the Color of Sky",
            Length = 200.4,
            Genres = new List<Genre> { GenreData.Genres[0] }
        },
        new Song
        {
            Id = 11,
            Title = "Titanium",
            ArtistId = 3,
            Album = "Nothing But the Beat",
            Length = 290.2,
            Genres = new List<Genre> { GenreData.Genres[1] }
        },
        new Song
        {
            Id = 12,
            Title = "In My Mind",
            ArtistId = 4,
            Album = "Animals",
            Length = 275.5, Genres = new List<Genre> { GenreData.Genres[1] }
        },
        new Song
        {
            Id = 13,
            Title = "So What",
            ArtistId = 5,
            Album = "Kind of Blue",
            Length = 310.7,
            Genres = new List<Genre> { GenreData.Genres[2] }
        },
        new Song
        {
            Id = 14,
            Title = "Giant Steps",
            ArtistId = 6,
            Album = "Giant Steps",
            Length = 295.1,
            Genres = new List<Genre> { GenreData.Genres[2] }
        },
        new Song
        {
            Id = 15,
            Title = "Stomp",
            ArtistId = 7,
            Album = "The Rebirth",
            Length = 215.8,
            Genres = new List<Genre> { GenreData.Genres[3] }
        },
        new Song
        {
            Id = 16,
            Title = "Break Every Chain",
            ArtistId = 8,
            Album = "Grace",
            Length = 230.3,
            Genres = new List<Genre> { GenreData.Genres[3] }
        },
        new Song
        {
            Id = 17,
            Title = "On The Low",
            ArtistId = 1,
            Album = "Twice as Tall",
            Length = 250.6,
            Genres = new List<Genre> { GenreData.Genres[0] }
        },
        new Song
        {
            Id = 18,
            Title = "For Now",
            ArtistId = 2,
            Album = "If Orange Was the Color of Sky",
            Length = 190.1,
            Genres = new List<Genre> { GenreData.Genres[0] }
        },
        new Song
        {
            Id = 19,
            Title = "When Love Takes Over",
            ArtistId = 3,
            Album = "Nothing But the Beat",
            Length = 280.4,
            Genres = new List<Genre> { GenreData.Genres[1] }
        },
        new Song
        {
            Id = 20,
            Title = "Animals",
            ArtistId = 4,
            Album = "Animals",
            Length = 265.7,
            Genres = new List<Genre> { GenreData.Genres[1] }
        }
    };
}

