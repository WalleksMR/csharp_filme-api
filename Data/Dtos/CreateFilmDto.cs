using System.ComponentModel.DataAnnotations;

namespace filmesAPI.Data.Dtos;

public class UpdateFilmDto
{
  public string Titulo { get; set; }
  [MaxLength(50, ErrorMessage = "should not exceed 50 characters")]
  public string Genero { get; set; }
  [Range(70, 600, ErrorMessage = "Duração should be between 70 and 600")]
  public int Duracao { get; set; }
}
