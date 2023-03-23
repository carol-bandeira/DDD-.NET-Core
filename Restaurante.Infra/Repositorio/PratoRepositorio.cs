using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositórios;
using Restaurante.Infra.Data.Contextos;

namespace Restaurante.Infra.Data.Repositorio
{
    public class PratoRepositorio : RepositorioBase<Prato>, IPratoRepositorio
    {
        public PratoRepositorio(Contexto contexto) 
            : base(contexto) {
        }
    }
}
