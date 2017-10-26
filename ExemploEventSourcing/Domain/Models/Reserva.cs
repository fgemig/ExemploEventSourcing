using ExemploEventSourcing.Domain.Common;
using FluentValidator.Validation;
using System;

namespace ExemploEventSourcing.Domain.Models
{
    public class Reserva : Entity
    {
        public Reserva (Veiculo veiculo, Motorista motorista, Periodo periodo)
        {
            Id = Guid.NewGuid();
            Veiculo = veiculo;
            Motorista = motorista;
            Periodo = periodo;

            AddNotifications(new ValidationContract()
                .IsNotNull(Veiculo, nameof(Veiculo), "Veículo não informado")
                .IsNotNull(Motorista, nameof(Motorista), "Motorista não informado")
                .IsNotNull(Periodo, nameof(Periodo), "Período não informado"));

            AddNotifications(veiculo, motorista, periodo);
        }
        
        public Veiculo Veiculo { get; private set; }

        public Motorista Motorista { get; private set; }

        public Periodo Periodo { get; private set; }
    }
}
