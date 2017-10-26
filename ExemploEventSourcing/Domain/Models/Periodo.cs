using ExemploEventSourcing.Domain.Common;
using FluentValidator.Validation;
using System;

namespace ExemploEventSourcing.Domain.Models
{
    public class Periodo : Entity
    {
        public Periodo(DateTime inicio, DateTime fim)
        {
            Id = Guid.NewGuid();
            Inicio = inicio;
            Fim = fim;

            AddNotifications(new ValidationContract()
                .IsGreaterThan(Inicio, DateTime.Now, nameof(Inicio), "A data de início deve ser maior que a data atual")
                .IsLowerThan(Inicio, Fim, nameof(Fim), "A data final tem que ser maior que a data de início"));
        }
        
        public DateTime Inicio { get; private set; }

        public DateTime Fim { get; private set; }

        public override string ToString()
        {
            return $"{Inicio.ToString("dd/MM HH:mm")} / {Fim.ToString("dd/MM HH:mm") }";
        }
    }
}
