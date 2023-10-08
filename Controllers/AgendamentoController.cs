namespace Agendamento.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agenday.Models;
using Agenday.Data;
using System;

[ApiController]
[Route("api/agendamento")]
public class AgendamentoController : ControllerBase
{
    private readonly AppDataContext _context;

    public AgendamentoController(AppDataContext context)
    {
        _context = context;
    }

    // GET: api/categoria/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Agendamentos> agendamentos = _context.Agendamentos.ToList();
            return Ok(agendamentos);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    // POST: api/categoria/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Agendamentos agendamento)
    {
        try
        {
            _context.Add(agendamento);
            _context.SaveChanges();
            return Created("", agendamento);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
