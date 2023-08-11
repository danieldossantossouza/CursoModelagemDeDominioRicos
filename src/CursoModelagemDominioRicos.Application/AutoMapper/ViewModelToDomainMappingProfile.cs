using AutoMapper;
using CursoModelagemDominioRicos.Application.ViewModels;
using ModelagemDominioRiscocurso.Catalogo.Domain;

namespace CursoModelagemDominioRicos.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile 
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProdutoViewModel,Produto>()
            .ConstructUsing(p =>
                    new Produto(p.Nome, p.Descricao, p.Ativo,
                        p.Valor, p.CategoriaId, p.DataCadastro,
                        p.Imagem, new Dimensoes(p.Altura, p.Largura, p.Profundidade)));
            CreateMap<CategoriaViewModel,Categoria>();
        }
    }
}
