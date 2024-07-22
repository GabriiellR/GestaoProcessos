using GestaoProcessos.Aplicacao.DTO;
using GestaoProcessos.Dominio;

namespace GestaoProcessos.Aplicacao.Interfaces
{
    public interface IApplicationServiceBase<TDTO, TEntity>
    {
        TDTO AddOrUpdate(TDTO dto);
        void Remove(TDTO dto);
        TDTO GetById(int Id);
        bool ExistById(int Id);
        List<TDTO> GetAll();
        List<TDTO> GetByIdList(List<int> ids);
        void Dispose();
    }
}
