using ModelagemDominioRiscoCurso.Core.DomainObjects;
using System;

namespace ModelagemDominioRiscoCurso.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
