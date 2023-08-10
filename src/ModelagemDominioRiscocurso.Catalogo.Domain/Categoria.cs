using ModelagemDominioRiscoCurso.Core.DomainObjects;

namespace ModelagemDominioRiscocurso.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public int Codigo { get; set;}

        //EF Relação
        protected Categoria()
        { }
        public ICollection<Produto>Produtos { get; set; }

        public Categoria(string nome,int codigo)
        {
            Nome = nome;
            Codigo = codigo;
            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo nome da categori não pode ser vazio! ");
            Validacoes.ValidaSeIgual(Codigo,0,"O campo codigo não pode ser zero!");

           

        }
    }
}
