using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]

        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        public string ImagemUpload { get; set; } // dado da imagem: Base64

        public string Imagem { get; set; } // nome da imagem

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        // what is this? ScaffoldColumnAttribute: it is used to specify that a property is not to be scaffolded.
        // what is a scaffolded property? A scaffolded property is a property that is used to generate the UI automatically.
        [ScaffoldColumn(false)]
        public string NomeFornecedor { get; set; }
    }
}