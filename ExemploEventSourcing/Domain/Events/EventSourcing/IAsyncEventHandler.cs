using MediatR;

namespace ExemploEventSourcing.Domain.Events.EventSourcing
{
    public interface IAsyncEventHandler<in TEvent> : IAsyncNotificationHandler<TEvent>
           where TEvent : IEvent
    {
    }
}
