using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Aplicacao.Interfaces.Administracao
{
    public interface IApplicationServiceUsuario : IApplicationServiceBase<UsuarioDTO, Usuario>
    {
        UsuarioDTO CadastrarUsuario(UsuarioDTO usuario);
        UsuarioDTO GetByLogin(string login);
    }
}
