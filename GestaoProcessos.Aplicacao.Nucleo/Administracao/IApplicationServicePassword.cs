namespace GestaoProcessos.Aplicacao.Interfaces.Administracao
{
    public interface IApplicationServicePassword
    {
        string GerarSalt();
        string GerarHashPassword(string password, string salt);
        bool VerificarPassword(string senha, string hash, string salt);
    }
}
