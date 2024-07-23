using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Aplicacao.Interfaces.Chamados;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProcesso.Aprensentacao.Controllers.Chamados
{
    [ApiController]
    [Route("api/chamados/[controller]")]
    public class ChamadoController : ControllerBase
    {
        readonly IApplicationServiceChamado _applicationServiceChamado;
        public ChamadoController(IApplicationServiceChamado applicationServiceChamado)
        {
            _applicationServiceChamado = applicationServiceChamado;
        }


        [HttpPost]
        public ActionResult Post(ChamadoDTO dto)
        {
            if (dto is null)
                return BadRequest("DTO não pode ser nulo");

            dto = _applicationServiceChamado.AddOrUpdate(dto);
            return new OkObjectResult(new { Message = "Dados adicionados", Data = dto });
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var dtoLiist = _applicationServiceChamado.GetAll();
            return new OkObjectResult(new { Message = "Dados obtidos com sucesso", Data = dtoLiist });
        }

    }
}
