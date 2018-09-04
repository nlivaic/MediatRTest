using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatRTest.SharedKernel.Interfaces
{
    // public abstract class BaseEventHandler<T> : INotificationHandler<T> where T : IDomainEvent
    // {
    //     public abstract void Handle(T args);
        
    //     public Task Handle(T notification, CancellationToken cancellationToken)
    //     {
    //         Handle(notification);
    //         return Task.CompletedTask;
    //     }
    // }
    public interface IEventHandler<T> : INotificationHandler<T> where T : IDomainEvent
    {
    }
}