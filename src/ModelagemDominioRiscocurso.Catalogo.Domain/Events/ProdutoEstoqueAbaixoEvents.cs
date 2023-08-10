using ModelagemDominioRiscoCurso.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelagemDominioRiscocurso.Catalogo.Domain.Events
{
    public class ProdutoEstoqueAbaixoEvents : DomainEvents
    {
        public int QuantidadeRestante { get; private set; }
        public ProdutoEstoqueAbaixoEvents(Guid aggregateId, int quantidadeRestante) : base(aggregateId)
        {
            QuantidadeRestante = quantidadeRestante;
        }
    }
}
