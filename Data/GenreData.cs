using System;
using TunaPiano_BE.Models;
namespace TunaPiano_BE.Data;

public class GenreData
{
	public static List<Genre> Genres = new List<Genre>()
	{
		new Genre
		{
			Id = 1,
			Description = "Afrobeat"
		},
        new Genre
        {
            Id = 2,
            Description = "EDM"
        },
        new Genre
        {
            Id = 2,
            Description = "Jazz"
        },
        new Genre
        {
            Id = 4,
            Description = "Gospel"
        },
    };
}

