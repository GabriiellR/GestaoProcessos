using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Dominio.Chamados;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Chamados
{
    public class FilaChamadoProfile : Profile
    {
        public FilaChamadoProfile()
        {
            CreateMap<FilaChamado, FilaChamadoDTO>().ReverseMap();
        }
    }
}
