using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Aplicacao.Interfaces.Administracao
{
    public interface IApplicationServiceToken
    {
        string GerarToken(Usuario usuario);
    }
}
