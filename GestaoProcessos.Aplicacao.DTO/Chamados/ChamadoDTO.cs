using GestaoProcessos.Aplicacao.DTO.Administracao;

namespace GestaoProcessos.Aplicacao.DTO.Chamados
{
    public class ChamadoDTO
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
        public virtual StatusChamadoDTO? Status { get; set; }
        public int UsuarioAberturaId { get; set; }
        public virtual UsuarioDTO? UsuarioAbertura { get; set; }
        public int? UsuarioSolucaoId { get; set; }
        public virtual UsuarioDTO? UsuarioSolucao { get; set; }
        public int FilaId { get; set; }
        public virtual FilaChamadoDTO? Fila { get; set; }
        public int CategoriaId { get; set; }
        public virtual CategoriaChamadoDTO? Categoria { get; set; }
        public int? SubfilaId { get; set; }
        public virtual SubfilaChamadoDTO? Subfila { get; set; }
    }
}
