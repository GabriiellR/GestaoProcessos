using GestaoProcessos.Dominio;

namespace GestaoProcessos.Dominio.Interfaces.Service
{
    public interface IServiceBase<TEntity>
    {
        void AddOrUpdate(TEntity dto);
        void Remove(TEntity dto);
        TEntity GetById(int Id);
        bool ExistById(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByIdList(List<int> ids);
        void Dispose();
    }
}