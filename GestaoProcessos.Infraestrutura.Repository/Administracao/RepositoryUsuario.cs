using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Interfaces.Repository.Administracao;
using GestaoProcessos.Infraestrutura.Data;

namespace GestaoProcessos.Infraestrutura.Repository.Administracao
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        readonly MysqlContext _context;

        public RepositoryUsuario(MysqlContext context) : base(context)
        {
            _context = context;
        }
        public Usuario GetByLogin(string login)
        {
            return _context.Usuarios.FirstOrDefault(prop => prop.Login.Equals(login));
        }
    }
}
