using Microsoft.EntityFrameworkCore;

namespace filmesAPI.Data;

public class FilmContext : DbContext
{
  public FilmContext(DbContextOptions<FilmContext> opts) : base(opts)
  {

  }
}