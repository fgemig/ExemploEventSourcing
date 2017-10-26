using MediatR;
using System.Threading.Tasks;

namespace ExemploEventSourcing.Domain.Events.EventSourcing
{
    public class EventBus : IEventBus
    {
        private readonly IMediator _mediatr;

        public EventBus(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public Task Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            return _mediatr.Publish(@event);
        }
    }
}
