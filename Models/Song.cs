using System;
using System.Collections.Generic;

namespace TunaPiano_BE.Models;

public class Song
{
	public int Id { get; set; }
	public string Title { get; set; }
	public int ArtistId { get; set; }
	public Artist Artist { get; set; }
	public string Album { get; set; }
	public double Length { get; set; }
	public List<Genre> Genres { get; set; }
}

