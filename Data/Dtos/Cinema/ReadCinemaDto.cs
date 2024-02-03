using filmesAPI.Data.Dtos.Endereco.FilmesApi.Data.Dtos;

namespace filmesAPI.Data.Dtos.Cinema
{
    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto Endereco { get; set; }
    }
}
