using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelagemDominioRiscocurso.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : INotificationHandler<ProdutoEstoqueAbaixoEvents>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoEventHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoEstoqueAbaixoEvents notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
