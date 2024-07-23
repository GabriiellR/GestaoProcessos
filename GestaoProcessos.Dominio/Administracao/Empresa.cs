namespace GestaoProcessos.Dominio.Administracao
{
    public class Empresa : BaseModel
    {
        public string Nome { get; set; } = string.Empty;    
        public List<Usuario>? Usuarios { get; set; }
    }
}
