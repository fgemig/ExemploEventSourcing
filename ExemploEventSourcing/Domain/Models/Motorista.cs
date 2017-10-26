using ExemploEventSourcing.Domain.Common;
using FluentValidator.Validation;
using System;

namespace ExemploEventSourcing.Domain.Models
{
    public class Motorista : Entity
    {
        public Motorista(string nome, string cnh)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            CNH = cnh;

            AddNotifications(new ValidationContract()
                .HasMinLen(Nome, 3, nameof(Nome), "O nome do Motorista deve ter no mínimo 3 caracteres")
                .HasLen(CNH, 11, nameof(CNH), "Informe o número da CNH corretamente"));
        }

        public string Nome { get; private set; }

        public string CNH { get; private set; }

        public override string ToString()
        {
            return $"{Nome}, CNH: {CNH}";
        }
    }
}
