using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Agenday.Models;
namespace Agenday.Controllers
{
    [Route("api/servico")]
    [ApiController]
    public class ServicoController : Controller
    {
        private List<Servico> _servicos = new List<Servico>();

        // Endpoint para listar todos os serviços
        [HttpGet]
        public IActionResult ListarServicos()
        {
            return Ok(_servicos);
        }

        // Endpoint para cadastrar um novo serviço
        [HttpPost]
        public IActionResult CadastrarServico([FromBody] Servico novoServico)
        {
            if (novoServico == null)
            {
                return BadRequest("Dados do serviço inválidos");
            }

            novoServico.ServicoID = Guid.NewGuid(); // Gere um ID único para o serviço
            _servicos.Add(novoServico);

            return CreatedAtAction(nameof(ListarServicos), novoServico);
        }
    }

    public class Servico
    {
        public Guid ServicoID { get; set; }
        public string Nome { get; set; }
        public string Cliente { get; set; }
        public string Usuario { get; set; }
        public decimal Preco { get; set; }
    }
}
