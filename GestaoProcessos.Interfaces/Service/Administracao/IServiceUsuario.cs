using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Dominio.Interfaces.Service.Administracao
{
    public interface IServiceUsuario : IServiceBase<Usuario>
    {
        Usuario GetByLogin(string login);
    }
}
