using ExemploEventSourcing.Domain.Commands.Events;
using ExemploEventSourcing.Domain.Commands.Inputs;
using ExemploEventSourcing.Domain.Commands.Results;
using ExemploEventSourcing.Domain.Events.EventSourcing;
using ExemploEventSourcing.Domain.Models;
using MediatR;
using System;
using System.Threading.Tasks;

namespace ExemploEventSourcing.Domain.Commands.Handlers
{
    public class ReservaCommandHandler : IAsyncRequestHandler<RegistrarReservaCommand, Response>
    {
        private readonly IEventBus _eventBus;

        public ReservaCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task<Response> Handle(RegistrarReservaCommand message)
        {
            var motorista = new Motorista(
                " ",
                "12345789111");

            var veiculo = new Veiculo(
                "AAA-1111",
                "Scania");

            var periodo = new Periodo(
                DateTime.Now.AddHours(1),
                DateTime.Now.AddHours(2));

            var reserva = new Reserva(veiculo, motorista, periodo);

            await _eventBus.Publish(new ReservaRegistradaEvent(message.Id, message.VeiculoId, message.MotoristaId, message.PeriodoId));

            return new Response(reserva.Id, reserva.Notifications);
        }
    }
}
