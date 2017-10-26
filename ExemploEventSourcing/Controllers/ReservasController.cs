using ExemploEventSourcing.Domain.Commands.Inputs;
using ExemploEventSourcing.Domain.Commands.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEventSourcing.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ReservasController : Controller
    {
        private readonly IMediator _mediatR;

        public ReservasController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [Route("v1/reserva")]
        public async Task<IActionResult> Post([FromBody] RegistrarReservaCommand command)
        {
            if (command == null)
                return BadRequest();

            var result = await _mediatR.Send(command);

            return Response(result);
        }

        public IActionResult Response(Response response)
        {
            if (response.Status == ResponseStatus.SUCESSO)
            {
                return Ok(new
                {
                    id = response.Id,
                    status = response.Status.ToString()
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = response.Status.ToString(),
                    notificacoes = response.Notificacoes
                });
            }
        }
    }
}
