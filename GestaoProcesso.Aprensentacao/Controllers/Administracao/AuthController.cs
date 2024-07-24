using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProcesso.Aprensentacao.Controllers.Administracao
{
    [ApiController]
    [Route("api/administracao/[controller]")]
    public class AuthController : ControllerBase
    {
        readonly IApplicationServiceAuth _applicationServiceAuth;
        readonly IApplicationServiceToken _applicationServiceToken;
        public AuthController(IApplicationServiceAuth applicationServiceAuth, IApplicationServiceToken applicationServiceToken)
        {
            _applicationServiceAuth = applicationServiceAuth;
            _applicationServiceToken = applicationServiceToken;
        }

        [HttpPost]
        public ActionResult Autenticar(AuthDTO dto)
        {
            try
            {
                var token = _applicationServiceAuth.Autenticar(dto);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
