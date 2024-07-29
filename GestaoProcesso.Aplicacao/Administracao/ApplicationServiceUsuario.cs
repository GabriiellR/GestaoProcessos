using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Interfaces.Service.Administracao;

namespace GestaoProcesso.Aplicacao.Administracao
{
    public class ApplicationServiceUsuario : ApplicationServiceBase<UsuarioDTO, Usuario>, IApplicationServiceUsuario
    {
        readonly IMapper _mapper;
        readonly IServiceUsuario _serviceUsuario;
        readonly IApplicationServicePassword _applicationServicePassword;
        public ApplicationServiceUsuario(IMapper mapper, IServiceUsuario serviceUsuario, IApplicationServicePassword applicationServicePassword) : base(mapper, serviceUsuario)
        {
            _serviceUsuario = serviceUsuario;
            _mapper = mapper;
            _applicationServicePassword = applicationServicePassword;

        }

        public UsuarioDTO CadastrarUsuario(UsuarioDTO usuarioDto)
        {
            try
            {
                var entity = _mapper.Map<Usuario>(usuarioDto);
                entity = GerarHashPassword(entity, usuarioDto);
                _serviceUsuario.AddOrUpdate(entity);

                return _mapper.Map<UsuarioDTO>(entity);
            }
            catch (Exception ex)
            {
                throw new OperationCanceledException(ex.Message);
            }
        }

        public UsuarioDTO GetByLogin(string login)
        {
            var entity = _serviceUsuario.GetByLogin(login);
            return _mapper.Map<UsuarioDTO>(entity);
        }

        private Usuario GerarHashPassword(Usuario entity, UsuarioDTO dto)
        {
            var salt = _applicationServicePassword.GerarSalt();
            entity.HashSenha = _applicationServicePassword.GerarHashPassword(dto.Senha, salt);
            entity.Salt = salt;

            return entity;
        }
    }
}
