using ExemploEventSourcing.Domain.Common;
using FluentValidator.Validation;
using System;

namespace ExemploEventSourcing.Domain.Models
{
    public class Veiculo : Entity
    {
        public Veiculo(string placa, string fabricante)
        {
            Id = Guid.NewGuid();
            Placa = placa;
            Fabricante = fabricante;

            AddNotifications(new ValidationContract()
                .HasLen(Placa, 8, nameof(Placa), "Placa do veículo inválida"));
        }
        
        public string Placa { get; private set; }

        public string Fabricante { get; private set; }

        public override string ToString()
        {
            return $"{Fabricante}, placa: {Placa}";
        }
    }
}
