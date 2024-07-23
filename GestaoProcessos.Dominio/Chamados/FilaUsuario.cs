using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Dominio.Chamados
{
    public class FilaUsuario : BaseModel
    {
        public int UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public int FilaId { get; set; }
        public virtual FilaChamado? Fila { get; set; }
    }
}
