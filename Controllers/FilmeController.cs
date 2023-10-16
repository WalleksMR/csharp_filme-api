using filmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace filmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : ControllerBase
{
  private static List<Filme> filmes = new List<Filme>();
  private static int id = 0;

  [HttpPost]
  public IActionResult AdicionarFilme([FromBody] Filme filme)
  {
    id = ++id;
    filme.Id = id;
    filmes.Add(filme);
    Console.WriteLine("ID:", filme.Id);
    Console.WriteLine("Titulo:", filme.Titulo);
    Console.WriteLine("Duracao:", filme.Duracao);

    return CreatedAtAction(nameof(LoadOne), new { id = filme.Id }, filme);
  }

  [HttpGet]
  public IEnumerable<Filme> ListAll([FromQuery] int skip = 0, [FromQuery] int take = 10)
  {
    return filmes.Skip(skip).Take(take);
  }

  [HttpGet("{id}")]
  public IActionResult LoadOne(int id)
  {
    var filme = filmes.FirstOrDefault((f) => f.Id == id);
    if (filme == null) return NotFound();
    return Ok(filme);
  }

}
