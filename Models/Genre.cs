using System;
namespace TunaPiano_BE.Models;

public class Genre
{
	public int Id { get; set; }
	public string? Description { get; set; }
	List<Song> Songs { get; set; }
}

