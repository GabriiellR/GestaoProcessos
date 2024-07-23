
using GestaoProcessos.Dominio.Chamados;
using GestaoProcessos.Dominio.Interfaces.Repository.Chamados;
using GestaoProcessos.Infraestrutura.Data;

namespace GestaoProcessos.Infraestrutura.Repository.Chamados
{
    public class RepositoryChamado : RepositoryBase<Chamado>, IRepositoryChamado
    {
        MysqlContext _context;
        public RepositoryChamado(MysqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
