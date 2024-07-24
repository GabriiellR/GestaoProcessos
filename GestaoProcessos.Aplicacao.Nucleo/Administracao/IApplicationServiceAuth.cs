using GestaoProcessos.Aplicacao.DTO.Administracao;

namespace GestaoProcessos.Aplicacao.Interfaces.Administracao
{
    public interface IApplicationServiceAuth
    {
        string Autenticar(AuthDTO dto);
    }
}
