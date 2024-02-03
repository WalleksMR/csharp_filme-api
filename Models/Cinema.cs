using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace filmesAPI.Models
{
    [Table("cinemas")]
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        [StringLength(255)]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
