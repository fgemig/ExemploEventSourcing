using ExemploEventSourcing.Domain.Events.EventSourcing;
using System;

namespace ExemploEventSourcing.Domain.Commands.Events
{
    public class ReservaRegistradaEvent : IEvent
    {
        public ReservaRegistradaEvent(Guid id, Guid veiculoId, Guid motoristaId, Guid periodoId)
        {
            Id = id;
            VeiculoId = veiculoId;
            MotoristaId = motoristaId;
            PeriodoId = periodoId;
        }

        public Guid Id { get; set; }
        public Guid VeiculoId { get; set; }
        public Guid MotoristaId { get; set; }
        public Guid PeriodoId { get; set; }
    }
}
