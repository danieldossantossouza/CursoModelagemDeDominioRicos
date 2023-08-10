using MediatR;

namespace ModelagemDominioRiscoCurso.Core.Messages
{
    public abstract class Event : Message, INotification
    {
        public DateTime TimesTamp { get; protected set; }

        protected Event()
        {
            TimesTamp = DateTime.Now;
        }
    }
}
