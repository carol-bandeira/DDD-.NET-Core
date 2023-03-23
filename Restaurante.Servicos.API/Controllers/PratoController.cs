using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Aplicacao.DTO;

namespace Restaurante.Servicos.API.Controllers
{
    public class PratoController : ControllerBase<Prato, PratoDTO> {
        public PratoController(IPratoApp app) 
            : base(app) 
        { }
    }
}
