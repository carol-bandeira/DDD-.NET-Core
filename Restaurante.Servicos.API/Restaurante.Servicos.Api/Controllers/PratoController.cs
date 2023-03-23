using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Aplicacao.DTO;

namespace Restaurante.Servico.Api.Controllers
{
    public class PratoController : ControllerBase<Prato, PratoDTO>
    {
        public PratoController(IPratoApp app)
            : base(app) { }
    }
}
