using ExemploEventSourcing.Domain.Commands.Events;
using ExemploEventSourcing.Domain.Events.EventSourcing;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExemploEventSourcing.Domain.Events.EventHandlers
{
    public class ReservasEventHandler : IAsyncEventHandler<ReservaRegistradaEvent>
    {
        public Task Handle(ReservaRegistradaEvent model)
        {
            HttpClient _httpClient = new HttpClient();

            return Task.Factory.StartNew(() =>
            {
                // faz algo, gravar um log, etc...
                _httpClient.GetStringAsync("https://www.google.com.br/");
            });
        }
    }
}
