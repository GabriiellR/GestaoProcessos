using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Dominio.Interfaces.Repository.Administracao
{
    public interface IRepositoryParametros : IRepositoryBase<Parametros>
    {
        Parametros GetByEmpresa(int empresaId);
    }
}
