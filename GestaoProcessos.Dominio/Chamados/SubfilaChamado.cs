namespace GestaoProcessos.Dominio.Chamados
{
    public class SubfilaChamado : BaseModel
    {
        public string Nome { get; set; } = string.Empty;
        public virtual List<Chamado>? Chamados { get; set; }
    }
}
