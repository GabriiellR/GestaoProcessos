using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Interfaces.Repository.Administracao;
using GestaoProcessos.Dominio.Interfaces.Service.Administracao;

namespace GestaoProcessos.Dominio.Servicos.Administracao
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        readonly IRepositoryUsuario _repositoryUsuario;
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) : base(repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }
        public Usuario GetByLogin(string login)
        {
            return _repositoryUsuario.GetByLogin(login);
        }
    }
}
