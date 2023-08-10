using ModelagemDominioRiscoCurso.Core.Messages;

namespace ModelagemDominioRiscoCurso.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
