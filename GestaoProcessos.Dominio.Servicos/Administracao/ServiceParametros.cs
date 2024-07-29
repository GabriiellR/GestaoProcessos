using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Interfaces.Repository.Administracao;
using GestaoProcessos.Dominio.Interfaces.Service.Administracao;

namespace GestaoProcessos.Dominio.Servicos.Administracao
{
    public class ServiceParametros : ServiceBase<Parametros>, IServiceParametros
    {
        readonly IRepositoryParametros _repositoryParametros;
        public ServiceParametros(IRepositoryParametros repositoryParametros) : base(repositoryParametros)
        {
            _repositoryParametros = repositoryParametros;
        }

        public Parametros GetByEmpresa(int empresaId)
        {
            return _repositoryParametros.GetByEmpresa(empresaId);
        }
    }
}
