using ExemploEventSourcing.Domain.Commands.Results;
using MediatR;
using System;

namespace ExemploEventSourcing.Domain.Commands.Inputs
{
    public class RegistrarReservaCommand : IRequest<Response>
    {
        public Guid Id { get; set; }
        public Guid VeiculoId { get; set; }
        public Guid MotoristaId { get; set; }
        public Guid PeriodoId { get; set; }
    }
}
