using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploEventSourcing.Domain.Commands.Results
{
    public enum ResponseStatus
    {
        SUCESSO,
        FALHA
    }

    public class Response
    {
        public Response(Guid? id, IReadOnlyCollection<Notification> notificacoes)
        {
            this.Id = id;
            this.Notificacoes = notificacoes;
        }

        public Guid? Id { get; private set; }

        public IReadOnlyCollection<Notification> Notificacoes { get; private set; }

        public ResponseStatus Status => Notificacoes.Any()
            ? ResponseStatus.FALHA
            : ResponseStatus.SUCESSO;
    }
}
