namespace GestaoProcessos.Dominio.Administracao
{
    public class Parametros : BaseModel
    {
        public string NomeSistema { get; set; } = string.Empty;
        public string Segredo { get; set; } = string.Empty;
        public int DuracaoToken { get; set; }
        public string DiretorioRaizArquivo { get; set; } = string.Empty;
        public string ExtensoesAceitas { get; set; } = string.Empty;
        public int TamanhoMaximoArquivo { get; set; }
        public int EmpresaId { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}
