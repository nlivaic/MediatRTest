using System.Linq;
using MediatRTest.SharedKernel;
using MediatRTest.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MediatRTest.Infrastructure
{
    public abstract class BaseDispatchContext : DbContext
    {
        private DomainEventsDispatcher _domainEventsDispatcher;

        protected BaseDispatchContext(DomainEventsDispatcher domainEventsDispatcher)
        {
            _domainEventsDispatcher = domainEventsDispatcher;
        }
        public override int SaveChanges()
        {
            var domainEventEntities = ChangeTracker.Entries<IEntity>()
                .Select(e => e.Entity);
            _domainEventsDispatcher.Dispatch(domainEventEntities);
            return base.SaveChanges();
        }
    }
}