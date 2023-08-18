using CursoModelagemDominioRicos.Application.Services;
using MediatR;
using ModelagemDominioRicos.Catalogo.Data;
using ModelagemDominioRicos.Catalogo.Data.Repository;
using ModelagemDominioRiscocurso.Catalogo.Domain;
using ModelagemDominioRiscocurso.Catalogo.Domain.Events;
using ModelagemDominioRiscoCurso.Core.Bus;

namespace ModelagemDominioRicos.WepApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterService(this IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoEstoqueAbaixoEvents>, ProdutoEventHandler>();
        }
    }
}
