using Microsoft.AspNetCore.Mvc;
using Agenday.Models;
using System.Collections.Generic;
using System.Linq;

namespace Agenday.AgendamentoController
{
    [Route("api/agendameto")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly DataContext _context;

        public AgendamentoController (DataContext context) =>
            _context = context;


        private static List<Agendamento> agendamentos = new List<Agendamento>();

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar() =>
            Ok(_context.Agendamento.ToList());


        //POST:  /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Agendamento agendamento)
        {
            _context.Agendamento.Add(agendamento);
            _context.SaveChanges();
            return Created("", agendamento);
        }

        // DELETE: /api/artista/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]
         public IActionResult Deletar([FromRoute] int id){
            Agendamento agendamento = _context.Agendamento.Find(id);
            if (agendamento != null)
            {
                _context.Agendamento.Remove(agendamento);
                _context.SaveChanges();
                return Ok(agendamento);
            }
            return NotFound();
        }

        // PATCH: /api/artista/alterar
        [Route("alterar")]
        [HttpPatch]

        public IActionResult Alterar([FromBody] Agendamento agendamento)
        {

            _context.Agendamento.Update(agendamento);
            _context.SaveChanges();
            return Ok(agendamento);
        }
    }

    internal class Agendamento
    {
    }

    internal class DataContext
    {
        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}