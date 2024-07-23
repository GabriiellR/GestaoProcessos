namespace GestaoProcessos.Dominio.Administracao
{
    public class Setor : BaseModel
    {
        public string Nome { get; set; } = string.Empty;
        public List<Usuario>? Usuarios { get; set; }
    }
}
