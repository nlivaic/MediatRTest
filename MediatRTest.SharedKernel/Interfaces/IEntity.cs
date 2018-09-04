using System.Collections.Generic;

namespace MediatRTest.SharedKernel.Interfaces {
    public interface IEntity
    {
        IEnumerable<IDomainEvent> DomainEvents { get; }
        void ClearEvents();
    }
}