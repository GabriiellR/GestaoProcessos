namespace GestaoProcessos.Dominio.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity>
    {
        void AddOrUpdate(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetById(int Id);
        bool ExistById(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByIdList(List<int> ids);
        void Dispose();
    }
}
