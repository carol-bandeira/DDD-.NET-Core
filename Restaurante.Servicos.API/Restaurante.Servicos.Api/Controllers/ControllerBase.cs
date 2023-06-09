﻿using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using AutoMapper;

namespace Restaurante.Servico.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : EntidadeBase
        where EntidadeDTO : DTOBase
    {
        readonly protected IAppBase<Entidade, EntidadeDTO> app;

        public ControllerBase(IAppBase<Entidade, EntidadeDTO> app) {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar() {
            try {
                var restaurantes = app.SelecionarTodos();
                return new OkObjectResult(restaurantes);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id) {
            try {
                var restaurantes = app.SelecionarPorId(id);
                return new OkObjectResult(restaurantes);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] EntidadeDTO dado) {
            try {
                if (dado.Id == null) {
                    return BadRequest("Id não deve ser nulo!");
                }
                else {
                    return new OkObjectResult(app.Incluir(dado));
                }
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO dado) {
            try {
                app.Alterar(dado);
                return new OkObjectResult(true);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id) {
            try {
                app.Excluir(id);
                return new OkObjectResult(true);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
