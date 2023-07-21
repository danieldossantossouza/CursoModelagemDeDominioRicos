using ModelagemDominioRiscocurso.Catalogo.Domain;
using ModelagemDominioRiscoCurso.Core.DomainObjects;

namespace ModelagemDeDominioRicos.Domain.Teste
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            var ex = Assert.Throws<DomainException>(() =>
                new Produto(Guid.NewGuid(),string.Empty,"Descricao",false,100,DateTime.Now, "Imagem",new Dimensoes(1,1,1))
            );
            Assert.Equal("O campo Nome não pode ser vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto(Guid.NewGuid(), "Nome", string.Empty, false, 100, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );
            Assert.Equal("O campo Descricao não pode ser vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto(Guid.NewGuid(), "Nome", "Descricao", false, 0, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );
            Assert.Equal("O campo Valor do produto não pode ser menor ou igual a zero", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto(Guid.Empty, "Nome", "Descricao", false, 100, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );
            Assert.Equal("O campo categoriaId do produto não pode ser vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto(Guid.NewGuid(), "Nome", "Descricao", false, 100, DateTime.Now, string.Empty, new Dimensoes(1, 1, 1))
            );
            Assert.Equal("O campo Imagem do produto não pode ser vazio", ex.Message);

        }
    }
}