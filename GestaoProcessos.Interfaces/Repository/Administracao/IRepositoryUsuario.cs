using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Dominio.Interfaces.Repository.Administracao
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario>
    {
        Usuario GetByLogin(string login);
    }
}
