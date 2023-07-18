using ModelagemDominioRiscoCurso.Core;
using ModelagemDominioRiscoCurso.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelagemDominioRiscocurso.Catalogo.Domain
{
    public class Produto : Entity,IAggregateRoot
    {
        public Produto(Guid categortiaId, string nome, string descricao, bool ativo,
                                        decimal valor, DateTime datacadastro, string imagem)
        {
            CategortiaId = categortiaId;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            Datacadastro = datacadastro;
            Imagem = imagem;
  
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

        public void AlterarCAtegoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public void AlterarDescricao(string desricao) 
        {
            Descricao = desricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if(quantidade < 0 ) quantidade *= -1;
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
        { }

    }

    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public int Codigo { get; set;}

        public Categoria(string nome,int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }


    }
}
