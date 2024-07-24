using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Interfaces.Service.Administracao;
using GestaoProcessos.Infraestrutura.CrossCutting.Extensions;

namespace GestaoProcesso.Aplicacao.Administracao
{
    public class ApplicationServiceAuth : IApplicationServiceAuth
    {
        readonly IServiceUsuario _serviceUsuario;
        readonly IApplicationServicePassword _applicationServicePassword;
        readonly IApplicationServiceToken _applicationServiceToken;
        public ApplicationServiceAuth(IServiceUsuario serviceUsuario, IApplicationServicePassword applicationServicePassword, IApplicationServiceToken applicationServiceToken)
        {
            _applicationServicePassword = applicationServicePassword;
            _applicationServiceToken = applicationServiceToken;
            _serviceUsuario = serviceUsuario;
        }
        public string Autenticar(AuthDTO dto)
        {
            try
            {
                if (dto.Login.IsNull() || dto.Senha.IsNull())
                    throw new Exception("Login ou senha inválidos.");

                var usuario = BuscarUsuario(dto.Login);
                var autenticado = _applicationServicePassword.VerificarPassword(dto.Senha, usuario.HashSenha, usuario.Salt);

                if (!autenticado)
                    throw new OperationCanceledException("Login ou senha inválidos.");

                var token = _applicationServiceToken.GerarToken(usuario);

                if (token.IsNull())
                    throw new OperationCanceledException("Falha ao gerar token.");

                return token;
            }
            catch (Exception ex)
            {
                //TODO LOGAR APOS IMPLEMENTAR SERILOG.
                throw new Exception(ex.Message);
            }
        }

        private Usuario BuscarUsuario(string login)
        {
            var usuario = _serviceUsuario.GetByLogin(login);

            if (usuario is null)
                throw new Exception("Login ou senha inválidos.");

            if (usuario.HashSenha.IsNull() || usuario.Salt.IsNull())
                throw new Exception("Login ou senha inválidos");

            return usuario;
        }
    }
}
