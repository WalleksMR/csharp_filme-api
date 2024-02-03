using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace filmesAPI.Models
{
    [Table("enderecos")]
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
