using ModelagemDominioRiscoCurso.Core.DomainObjects;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace ModelagemDominioRiscocurso.Catalogo.Domain
{
    public class Produto : Entity,IAggregateRoot
    {
        public Produto(Guid categoriaId, string nome, string descricao, bool ativo,
                                        decimal valor, DateTime datacadastro, string imagem)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            Datacadastro = datacadastro;
            Imagem = imagem;
            Validar();
  
        }

        public Guid CategoriaId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Datacadastro { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public string Imagem { get; private set; }
        public Categoria Categoria { get; private set; }


        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public void AlterarDescricao(string desricao) 
        {
            Validacoes.ValidarSevazio(desricao,"O campo Descriação do produto não pode estar vazio!");
            Descricao = desricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if(quantidade < 0 ) quantidade *= -1;
            if (!PossuiEstoque(quantidade)) throw new DomainException("Estoque insuficiente.");
            QuantidadeEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        { 
            QuantidadeEstoque += quantidade;
        }
        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }

        public void Validar()
        {
            Validacoes.ValidarSevazio(Nome, "O campo nome não pode ser vazio! ");
            Validacoes.ValidarSevazio(Descricao, "O campo descrição não pode ser vazio!");
            Validacoes.ValidaSeDiferente(CategoriaId,Guid.Empty,"O campo categoriaId do produto não pode ser nulo!");
            Validacoes.ValidarSeMenorIgualMinimo(Valor,0,"O campo valor do porduto não pode ser menor ou igual a zero!");
            Validacoes.ValidarSevazio(Imagem,"o campo Imagem do produto não pode ser vazio!");
        
        }

    }
}
