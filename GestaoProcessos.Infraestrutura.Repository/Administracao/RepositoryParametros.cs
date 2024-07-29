using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Interfaces.Repository.Administracao;
using GestaoProcessos.Infraestrutura.Data;

namespace GestaoProcessos.Infraestrutura.Repository.Administracao
{
    public class RepositoryParametros : RepositoryBase<Parametros>, IRepositoryParametros
    {
        readonly MysqlContext _context;
        public RepositoryParametros(MysqlContext context) : base(context)
        {
            _context = context;
        }

        public Parametros GetByEmpresa(int empresaId)
        {
            return _context.Parametros.FirstOrDefault(prop => prop.EmpresaId.Equals(empresaId));
        }
    }
}
