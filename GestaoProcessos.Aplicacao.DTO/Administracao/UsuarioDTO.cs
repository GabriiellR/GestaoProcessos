using System;

namespace GestaoProcessos.Aplicacao.DTO.Administracao
{
    public class UsuarioDTO : BaseDTO
    {
        public string Senha { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public DateOnly DataNascimento { get; set; }
        public bool Status { get; set; }
        public int FilialId { get; set; }
        public int SetorId { get; set; }
        public int EmpresaId { get; set; }
        public int? GestorId { get; set; }
        public int FuncaoId { get; set; }
    }
}
