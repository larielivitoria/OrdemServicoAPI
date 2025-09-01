using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrdemServico.Application.DTOs;
using OrdemServico.Application.Interfaces;
using OrdemServico.Application.Services;
using OrdemServico.Domain.Entities;
using OrdemServico.Infrastructure.Data;

namespace OrdemServico.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly IServicoService _servicoService;
        public ServicoController(IServicoService servicoService)
        {
            _servicoService = servicoService;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            var servicos = _servicoService.ListarTodos();
            return Ok(servicos);
        }

        [HttpPost]
        public IActionResult CriarServico([FromBody] CriarServicoDTO criarServicoDTO)
        {
            var servico = _servicoService.CriarServico(criarServicoDTO);
            return CreatedAtAction(nameof(ListarTodos), new {id = servico.Id}, servico);
        }

        [HttpDelete("{id}")]
        public IActionResult Apagar(int id)
        {
            _servicoService.Apagar(id);
            return NoContent();
        }
    }
}