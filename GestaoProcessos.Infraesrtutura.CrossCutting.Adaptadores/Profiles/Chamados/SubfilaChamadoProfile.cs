using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Dominio.Chamados;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Chamados
{
    public class SubfilaChamadoProfile : Profile
    {
        public SubfilaChamadoProfile()
        {
            CreateMap<SubfilaChamado, SubfilaChamadoDTO>().ReverseMap();
        }
    }
}
