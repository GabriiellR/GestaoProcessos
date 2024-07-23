using GestaoProcessos.Dominio.Chamados;
using GestaoProcessos.Dominio.Interfaces.Repository.Chamados;
using GestaoProcessos.Dominio.Interfaces.Service.Chamados;

namespace GestaoProcessos.Dominio.Servicos.Chamados
{
    public class ServiceChamado : ServiceBase<Chamado>, IServiceChamado
    {
        readonly IRepositoryChamado _repositoryChamado;
        public ServiceChamado(IRepositoryChamado repositoryChamado) : base(repositoryChamado)
        {
            _repositoryChamado = repositoryChamado;
        }
    }
}
