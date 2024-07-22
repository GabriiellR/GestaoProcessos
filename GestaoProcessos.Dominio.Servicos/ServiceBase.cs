using GestaoProcessos.Dominio.Interfaces.Repository;
using GestaoProcessos.Dominio.Interfaces.Service;

namespace GestaoProcessos.Dominio.Servicos
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity>, IDisposable
    {
        readonly IRepositoryBase<TEntity> _repositoryBase;
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void AddOrUpdate(TEntity dto)
        {
            _repositoryBase.AddOrUpdate(dto);
        }

        public bool ExistById(int Id)
        {
            return _repositoryBase.ExistById(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int Id)
        {
            return _repositoryBase.GetById(Id);
        }

        public IEnumerable<TEntity> GetByIdList(List<int> ids)
        {
            return _repositoryBase.GetByIdList(ids);
        }

        public void Remove(TEntity dto)
        {
            _repositoryBase.Remove(dto);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }
    }
}