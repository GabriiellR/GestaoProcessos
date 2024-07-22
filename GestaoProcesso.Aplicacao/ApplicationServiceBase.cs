using AutoMapper;
using GestaoProcessos.Aplicacao.Interfaces;
using GestaoProcessos.Dominio.Interfaces.Service;

namespace GestaoProcesso.Aplicacao
{
    public abstract class ApplicationServiceBase<TDTO, TEntity> : IApplicationServiceBase<TDTO, TEntity>, IDisposable
    {
        readonly IServiceBase<TEntity> _serviceBase;
        readonly IMapper _mapper;

        public ApplicationServiceBase(IMapper mapper, IServiceBase<TEntity> serviceBase)
        {
            _mapper = mapper;
            _serviceBase = serviceBase;
        }

        public TDTO AddOrUpdate(TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _serviceBase.AddOrUpdate(entity);
            return _mapper.Map<TDTO>(entity);
        }

        public bool ExistById(int Id)
        {
            return _serviceBase.ExistById(Id);
        }

        public List<TDTO> GetAll()
        {
            var entityList = _serviceBase.GetAll();
            return _mapper.Map<List<TDTO>>(entityList);
        }

        public TDTO GetById(int Id)
        {
            var entity = _serviceBase.GetAll();
            return _mapper.Map<TDTO>(entity);
        }

        public List<TDTO> GetByIdList(List<int> ids)
        {
            var entityList = _serviceBase.GetByIdList(ids);
            return _mapper.Map<List<TDTO>>(entityList);
        }

        public void Remove(TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _serviceBase.Remove(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}