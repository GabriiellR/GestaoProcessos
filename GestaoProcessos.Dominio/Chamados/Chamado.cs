using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Dominio.Chamados
{
    public class Chamado : BaseModel
    {
        public DateTime DataAbertura { get; set; }
        public DateTime? DataAtendimento { get; set; }
        public DateTime? DataSolucao { get; set; }
        public DateTime? DataFechamento { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Solucao { get; set; } = string.Empty;
        public TimeSpan? TempoSolucao { get; set; }
        public TimeSpan? TempoAtendimento { get; set; }
        public int StatusId { get; set; }
        public virtual StatusChamado? Status { get; set; }
        public int UsuarioAberturaId { get; set; }
        public virtual Usuario? UsuarioAbertura { get; set; }
        public int? UsuarioSolucaoId { get; set; }
        public virtual Usuario? UsuarioSolucao { get; set; }
        public int FilaId { get; set; }
        public virtual FilaChamado? Fila { get; set; }
        public int CategoriaId { get; set; }
        public virtual CategoriaChamado? Categoria { get; set; }
        public int? SubfilaId { get; set; }
        public virtual SubfilaChamado? Subfila { get; set; }
    }
}
