using System.ComponentModel.DataAnnotations;

namespace CursoModelagemDominioRicos.Application.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatorio ! ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio ! ")]
        public int Codigo { get; set; }

    }
}