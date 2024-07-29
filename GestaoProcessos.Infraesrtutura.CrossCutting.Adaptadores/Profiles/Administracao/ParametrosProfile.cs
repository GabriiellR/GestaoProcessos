using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Administracao
{
    public class ParametrosProfile : Profile
    {
        public ParametrosProfile()
        {
            CreateMap<ParametrosDTO, Parametros>().ReverseMap();
        }
    }
}
