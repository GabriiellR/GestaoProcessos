namespace GestaoProcessos.Dominio.Chamados
{
    public class FilaChamado : BaseModel
    {
        public string Nome { get; set; } = string.Empty;
        public virtual List<Chamado>? Chamados { get; set; }
        public virtual List<FilaUsuario> FilasUsuarios { get; set; }
    }
}
