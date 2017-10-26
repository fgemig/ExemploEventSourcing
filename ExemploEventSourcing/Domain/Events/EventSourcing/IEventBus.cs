using System.Threading.Tasks;

namespace ExemploEventSourcing.Domain.Events.EventSourcing
{
    public interface IEventBus
    {
        Task Publish<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
