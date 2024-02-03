using System.ComponentModel.DataAnnotations;

namespace filmesAPI.Data.Dtos.Sessao
{
    public class CreateSessaoDto
    {
        [Required]
        public int FilmeId { get; set; }
    }
}
