namespace Agenday.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agenday.Models;
using Agenday.Data;
using System;

[ApiController]
[Route("api/cliente")]
public class AgendamentoClienteController : ControllerBase
{
    private readonly AppDataContext _context;

    public AgendamentoClienteController(AppDataContext context)
    {
        _context = context;
    }

    // GET: api/categoria/listar
    [HttpGet]
    [Route("listarcliente")]
    public IActionResult Listar()
    {
        try
        {
            List<NovoCliente> novoClientes = _context.NovoClientes.ToList();
            return Ok(novoClientes);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    // POST: api/categoria/cadastrar
    [HttpPost]
    [Route("cadastrarcliente")]
    public IActionResult Cadastrar([FromBody] NovoCliente novoCliente)
    {
        try
        {
            _context.Add(novoCliente);
            _context.SaveChanges();
            return Created("", novoCliente);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
