using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Dominio.Chamados;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Chamados
{
    public class ChamadoProfile : Profile
    {
        public ChamadoProfile()
        {
            CreateMap<Chamado, ChamadoDTO>().ReverseMap();
        }
    }
}
