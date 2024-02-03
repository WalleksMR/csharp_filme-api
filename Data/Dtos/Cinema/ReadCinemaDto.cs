using filmesAPI.Data.Dtos.Endereco;

namespace filmesAPI.Data.Dtos.Cinema
{
    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto ReadEndereco { get; set; }
    }
}
