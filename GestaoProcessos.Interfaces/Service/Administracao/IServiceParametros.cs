using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Dominio.Interfaces.Service.Administracao
{
    public interface IServiceParametros : IServiceBase<Parametros>
    {
        Parametros GetByEmpresa(int empresaId);
    }
}
