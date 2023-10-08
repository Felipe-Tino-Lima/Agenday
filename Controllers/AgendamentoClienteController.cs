using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Agenday.Models;
using Agenday.Data;



namespace Agenday.Controllers;

[ApiController]
[Route("api/cliente")]
public class AgendamentoClienteController : Controller
{
    private static List<NovoCliente> clientes = new List<NovoCliente>();

    // Ação para exibir a lista de Clientes
    public IActionResult Index()
    {
        return View(clientes);
    }

    // Ação para exibir o formulário de criação de clientes

    [HttpGet]
    [Route("listarcliente")]
    public IActionResult NovoCliente()
    {
        return View();
    }

    // Ação para lidar com o POST do formulário de criação de clientes
    [HttpPost]
    [Route("cadastrarcliente")]


    public IActionResult NovoCliente(NovoCliente cliente)
    {
        cliente.DataCriacao = DateTime.Now;
        clientes.Add(cliente);

        return RedirectToAction("Index");
    }
}
