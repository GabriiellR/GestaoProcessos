using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProcesso.Aprensentacao.Controllers.Administracao
{
    [ApiController]
    [Route("api/adminsitracao/[controller]")]
    public class UsuarioController : ControllerBase
    {
        readonly IApplicationServiceUsuario _applicationServiceUsuario;

        public UsuarioController(IApplicationServiceUsuario applicationServiceUsuario)
        {
            _applicationServiceUsuario = applicationServiceUsuario;
        }

        [Authorize]
        [HttpPost("novo-usuario")]
        public ActionResult NovoUsuario(UsuarioDTO usuario)
        {
            if (usuario is null)
                return BadRequest();

            var dto = _applicationServiceUsuario.CadastrarUsuario(usuario);

            return Ok(dto);
        }
    }
}
