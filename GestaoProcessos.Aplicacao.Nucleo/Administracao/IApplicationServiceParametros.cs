using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Aplicacao.Interfaces.Administracao
{
    public interface IApplicationServiceParametros : IApplicationServiceBase<ParametrosDTO, Parametros>
    {
        ParametrosDTO GetByEmpresa(int empresaId);
    }
}
