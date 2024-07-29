using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Interfaces.Service.Administracao;

namespace GestaoProcesso.Aplicacao.Administracao
{
    public class ApplicationServiceParametros : ApplicationServiceBase<ParametrosDTO, Parametros>, IApplicationServiceParametros
    {
        readonly IMapper _mapper;
        readonly IServiceParametros _serviceParametros;
        public ApplicationServiceParametros(IMapper mapper, IServiceParametros service) : base(mapper, service)
        {
            _mapper = mapper;
            _serviceParametros = service;
        }

        public ParametrosDTO GetByEmpresa(int empresaId)
        {
            var entity = _serviceParametros.GetByEmpresa(empresaId);
            return _mapper.Map<ParametrosDTO>(entity);
        }
    }
}
