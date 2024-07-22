using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Dominio.Chamados;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Chamados
{
    public class CategoriaChamadoProfile : Profile
    {
        public CategoriaChamadoProfile()
        {
            CreateMap<CategoriaChamado, CategoriaChamadoDTO>().ReverseMap();
        }
    }
}
