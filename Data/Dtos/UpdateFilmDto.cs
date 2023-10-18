using System.ComponentModel.DataAnnotations;

namespace filmesAPI.Data.Dtos;

public class CreateFilmDto
{

  [Required(ErrorMessage = "Titulo is required")]
  public string Titulo { get; set; }

  [Required(ErrorMessage = "Genero is required")]
  [MaxLength(50, ErrorMessage = "should not exceed 50 characters")]
  public string Genero { get; set; }

  [Required(ErrorMessage = "Duracao is required")]
  [Range(70, 600, ErrorMessage = "Duração should be between 70 and 600")]
  public int Duracao { get; set; }
}
