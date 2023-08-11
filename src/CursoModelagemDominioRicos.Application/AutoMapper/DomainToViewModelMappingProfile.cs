﻿using AutoMapper;
using CursoModelagemDominioRicos.Application.ViewModels;
using ModelagemDominioRiscocurso.Catalogo.Domain;

namespace CursoModelagemDominioRicos.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile :Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(d => d.Largura, o => o.MapFrom(s => s.Dimensoes.Largura))
                .ForMember(d => d.Altura, o => o.MapFrom(s => s.Dimensoes.Altura))
                .ForMember(d => d.Profundidade, o => o.MapFrom(s => s.Dimensoes.Profundidade));

            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}
