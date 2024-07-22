using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Chamados;
using GestaoProcessos.Dominio.Chamados;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Chamados
{
    public class FilaUsuarioProfile : Profile
    {
        public FilaUsuarioProfile()
        {
            CreateMap<FilaUsuario, FilaUsuarioDTO>().ReverseMap();
        }
    }
}
