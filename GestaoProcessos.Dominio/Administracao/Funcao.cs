namespace GestaoProcessos.Dominio.Administracao
{
    public class Funcao : BaseModel
    {
        public string Nome { get; set; } = string.Empty;
        public virtual List<Usuario>? Usuarios { get; set; }
    }
}
