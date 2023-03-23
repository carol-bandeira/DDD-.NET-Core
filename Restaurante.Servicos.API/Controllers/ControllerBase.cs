using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Restaurante.Servicos.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : EntidadeBase
        where EntidadeDTO : BaseDTO
    {
        readonly protected IAppBase<Entidade, EntidadeDTO> app;

        public ControllerBase(IAppBase<Entidade, EntidadeDTO> app) {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar() {
            try {
                var restarantes = app.SelectAll();
                return new OkObjectResult(restarantes);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id) {
            try {
                var restarantes = app.GetById(id);
                return new OkObjectResult(restarantes);
            } 
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] EntidadeDTO dado) {
            try {
                return new OkObjectResult(app.Incluir(dado));
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO dado) {
            try {
                app.Alterar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id) {
            try {
                app.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
