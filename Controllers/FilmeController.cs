using AutoMapper;
using filmesAPI.Data;
using filmesAPI.Data.Dtos;
using filmesAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace filmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : ControllerBase
{
  private FilmContext _context;
  private IMapper _mapper;
  public FilmesController(FilmContext context, IMapper mapper)
  {
    _context = context;
    _mapper = mapper;
  }

  [HttpPost]
  public IActionResult AdicionarFilme([FromBody] CreateFilmDto filmeDto)
  {
    Filme filme = _mapper.Map<Filme>(filmeDto);
    _context.Filmes.Add(filme);
    _context.SaveChanges();
    return CreatedAtAction(nameof(LoadOne), new { id = filme.Id }, filme);
  }

  [HttpGet]
  public IEnumerable<Filme> ListAll([FromQuery] int skip = 0, [FromQuery] int take = 10)
  {
    return _context.Filmes.Skip(skip).Take(take);
  }

  [HttpGet("{id}")]
  public IActionResult LoadOne(int id)
  {
    var filme = _context.Filmes.FirstOrDefault((f) => f.Id == id);
    if (filme == null) return NotFound();
    return Ok(filme);
  }

  [HttpPut("{id}")]
  public IActionResult UpdateFilm(int id, [FromBody] UpdateFilmDto filmeDto)
  {
    var filme = _context.Filmes.FirstOrDefault((f) => f.Id == id);
    if (filme == null) return NotFound();
    _mapper.Map(filmeDto, filme);
    _context.SaveChanges();
    return NoContent();
  }

  [HttpPatch("{id}")]
  public IActionResult UpdateFilmPartial(int id, JsonPatchDocument<UpdateFilmDto> patch)
  {
    var filme = _context.Filmes.FirstOrDefault((f) => f.Id == id);
    if (filme == null) return NotFound();

    var filmeDto = _mapper.Map<UpdateFilmDto>(filme);
    patch.ApplyTo(filmeDto, ModelState);
    if (!TryValidateModel(ModelState))
    {
      return ValidationProblem(ModelState);
    }
    _mapper.Map(filmeDto, filme);
    _context.SaveChanges();
    return NoContent();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    var filme = _context.Filmes.FirstOrDefault((f) => f.Id == id);
    if (filme == null) return NotFound();
    _context.Remove(filme);
    _context.SaveChanges();
    return NoContent();
  }


}
