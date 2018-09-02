namespace MediatRTest.SharedKernel.Interfaces
{
    public interface IEventHandler<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}