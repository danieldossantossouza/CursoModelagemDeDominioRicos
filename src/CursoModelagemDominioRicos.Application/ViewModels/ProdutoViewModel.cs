using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoModelagemDominioRicos.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatorio !")]
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public string? Imagem { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="O campo {0} precisa ter o valor minimo de {1}")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public int QuantidadeEstoque { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor minimo de {1}")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public int Altura { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor minimo de {1}")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public int Largura { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor minimo de {1}")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio !")]
        public int Profundidade { get; set; }

        public IEnumerable<CategoriaViewModel>Categorias{ get; set; }
    }
}
