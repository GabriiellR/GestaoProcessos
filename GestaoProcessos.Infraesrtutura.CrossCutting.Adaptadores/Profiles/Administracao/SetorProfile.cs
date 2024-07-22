using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Administracao
{
    public class SetorProfile : Profile
    {
        public SetorProfile()
        {
            CreateMap<Setor, SetorDTO>().ReverseMap();
        }
    }
}
