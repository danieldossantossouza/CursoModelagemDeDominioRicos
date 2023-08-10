using ModelagemDominioRiscoCurso.Core.Messages;

namespace ModelagemDominioRiscoCurso.Core.DomainObjects
{
    public class DomainEvents : Event
    {
        public DomainEvents(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
