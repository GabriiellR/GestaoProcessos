using AutoMapper;
using GestaoProcessos.Aplicacao.DTO.Administracao;
using GestaoProcessos.Dominio.Administracao;

namespace GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Administracao
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}
