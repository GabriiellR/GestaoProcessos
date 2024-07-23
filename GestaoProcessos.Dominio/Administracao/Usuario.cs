using GestaoProcessos.Dominio.Chamados;

namespace GestaoProcessos.Dominio.Administracao
{
    public class Usuario : BaseModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public DateOnly DataNascimento { get; set; }
        public bool Status { get; set; }

        public int FilialId { get; set; }
        public virtual Filial? Filial { get; set; }
        public int SetorId { get; set; }
        public virtual Setor? Setor { get; set; }
        public int EmpresaId { get; set; }
        public virtual Empresa? Empresa { get; set; }
        public int GestorId { get; set; }
        public virtual Usuario? Gestor { get; set; }
        public int FuncaoId { get; set; }
        public virtual Funcao? Funcao { get; set; }

        public virtual List<Usuario>? UsuariosSubordinados { get; set; }
        public virtual List<Chamado>? ChamadosAbertura { get; set; }
        public virtual List<Chamado>? ChamadosSolucao { get; set; }
        public virtual List<FilaUsuario>? FilasUsuarios { get; set; }

    }
}
