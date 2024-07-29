namespace GestaoProcessos.Aplicacao.DTO.Administracao
{
    public class ParametrosDTO
    {
        public string NomeSistema { get; set; } = string.Empty;
        public string Segredo { get; set; } = string.Empty;
        public int DuracaoToken { get; set; }
        public string DiretorioRaizArquivo { get; set; } = string.Empty;
        public string ExtensoesAceitas { get; set; } = string.Empty;
        public int TamanhoMaximoArquivo { get; set; }
        public int EmpresaId { get; set; }
    }
}
