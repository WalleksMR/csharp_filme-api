using filmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace filmesAPI.Data;

public class FilmContext : DbContext
{
  public FilmContext(DbContextOptions<FilmContext> opts) : base(opts)
  {

  }
  public DbSet<Filme> Filmes { get; set; }
}