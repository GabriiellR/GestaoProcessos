using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Aplicacao.Interfaces.Chamados;
using GestaoProcessos.Dominio.Chamados;
using GestaoProcessos.Dominio.Interfaces.Service.Chamados;

namespace GestaoProcesso.Aplicacao.Chamados
{
    public class ApplicationServiceChamado : ApplicationServiceBase<ChamadoDTO, Chamado>, IApplicationServiceChamado
    {
        readonly IMapper _mapper;
        readonly IServiceChamado _serviceChamado;

        public ApplicationServiceChamado(IMapper mapper, IServiceChamado serviceChamado) : base(mapper, serviceChamado)
        {
            _mapper = mapper;
            _serviceChamado = serviceChamado;
        }
    }
}
