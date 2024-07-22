using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Administracao
{
    public class FilialProfile : Profile
    {
        public FilialProfile()
        {
            CreateMap<Filial, FilialDTO>().ReverseMap();
        }
    }
}
