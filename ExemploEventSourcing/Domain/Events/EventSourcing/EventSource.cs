using System;
using System.Collections.Generic;

namespace ExemploEventSourcing.Domain.Events.EventSourcing
{
    public abstract class EventSource
    {
        public Guid Id { get; protected set; }

        public Queue<IEvent> Fila { get; private set; }

        protected EventSource()
        {
            Fila = new Queue<IEvent>();
        }

        protected void Append(IEvent @event)
        {
            Fila.Enqueue(@event);
        }
    }
}
