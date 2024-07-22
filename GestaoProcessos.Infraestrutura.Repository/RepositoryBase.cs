using GestaoProcessos.Dominio;
using GestaoProcessos.Dominio.Interfaces.Repository;
using GestaoProcessos.Infraestrutura.Data;

namespace GestaoProcessos.Infraestrutura.Repository
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : BaseModel
    {
        readonly MysqlContext _context;

        public RepositoryBase(MysqlContext context)
        {
            _context = context;
        }
        public void AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public bool ExistById(int Id)
        {
            return _context.Set<TEntity>().Any(x => x.Id == Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int Id)
        {
            return _context.Set<TEntity>().FirstOrDefault(x => x.Id.Equals(Id));
        }

        public IEnumerable<TEntity> GetByIdList(List<int> ids)
        {
            return _context.Set<TEntity>().Where(x => ids.Contains(x.Id.Value)).ToList();
        }

        public void Remove(TEntity entity)
        {
            _context.Remove(entity);
        }
    }
}
