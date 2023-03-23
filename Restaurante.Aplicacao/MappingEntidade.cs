using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;
using Restaurante.Aplicacao;


namespace Restaurante.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade() {
            CreateMap<Prato, PratoDTO>();
            CreateMap<PratoDTO, Prato>();
        }
    }
}
