using System;
using System.Collections.Generic;
using MediatRTest.SharedKernel.Interfaces;

namespace MediatRTest.SharedKernel
{
    public abstract class Entity<TId>
    {
        private readonly IList<IDomainEvent> _domainEvents;
        public IEnumerable<IDomainEvent> DomainEvents => _domainEvents;
        protected Entity()
        {
            _domainEvents = new List<IDomainEvent>();
        }
        protected virtual void AddDomainEvent(IDomainEvent newEvent)
        {
            _domainEvents.Add(newEvent);
        }
        public virtual void ClearEvents()
        {
            _domainEvents.Clear();
        }
    }
}
