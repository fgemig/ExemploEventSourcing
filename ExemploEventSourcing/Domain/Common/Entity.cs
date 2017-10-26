using FluentValidator;
using System;

namespace ExemploEventSourcing.Domain.Common
{
    public abstract class Entity : Notifiable
    {
        public Guid Id { get; set; }
    }
}
