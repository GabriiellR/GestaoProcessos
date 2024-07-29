using GestaoProcesso.Aplicacao.Hubs;
using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Aplicacao.Interfaces.Chamados;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace GestaoProcesso.Aprensentacao.Controllers.Chamados
{
    [ApiController]
    [Route("api/chamados/[controller]")]
    public class ChamadoController : ControllerBase
    {
        readonly IApplicationServiceChamado _applicationServiceChamado;
        readonly IHubContext<ChamadoHub> _hubContext;
        public ChamadoController(IApplicationServiceChamado applicationServiceChamado, IHubContext<ChamadoHub> hubContext)
        {
            _applicationServiceChamado = applicationServiceChamado;
            _hubContext = hubContext;
        }


        [HttpPost]
        public async Task<ActionResult> Post(ChamadoDTO dto)
        {
            if (dto is null)
                return BadRequest("DTO não pode ser nulo");

            dto = _applicationServiceChamado.AddOrUpdate(dto);
            await _hubContext.Clients.All.SendAsync("newMessage", dto);

            return new OkObjectResult(new { Message = "Dados adicionados", Data = dto });
        }

        [Authorize]
        [HttpGet]
        public ActionResult GetAll()
        {
            var dtoLiist = _applicationServiceChamado.GetAll();
            return new OkObjectResult(new { Message = "Dados obtidos com sucesso", Data = dtoLiist });
        }

    }
}
