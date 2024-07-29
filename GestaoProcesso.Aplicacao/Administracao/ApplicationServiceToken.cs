using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Infraestrutura.CrossCutting.Extensions;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GestaoProcesso.Aplicacao.Administracao
{
    public class ApplicationServiceToken : IApplicationServiceToken
    {
        readonly IApplicationServiceParametros _applicationServiceParametros;
        public ApplicationServiceToken(IApplicationServiceParametros applicationServiceParametros)
        {
            _applicationServiceParametros = applicationServiceParametros;
        }

        public string GerarToken(Usuario usuario)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var secret = BuscarSecret(usuario);

                var key = Encoding.ASCII.GetBytes(secret);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim("id", usuario.Id.ToString()),
                    new Claim("empresaId", usuario.EmpresaId.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.Email, usuario.Email),
                    }),

                    Expires = DateTime.Now.AddHours(4),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                throw new OperationCanceledException(ex.Message);
            }
        }

        private string BuscarSecret(Usuario usuario)
        {
            try
            {
                var parametro = _applicationServiceParametros.GetByEmpresa(usuario.EmpresaId);

                if (parametro is null)
                    throw new Exception("Erro ao buscar paramêtros.");

                if (parametro.Segredo.IsNull())
                    throw new Exception("Erro ao obter parâmetro para gerar token");

                return parametro.Segredo;
            }
            catch (Exception ex)
            {
                throw new OperationCanceledException(ex.Message);
            }
        }
    }
}
