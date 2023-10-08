using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Agenday.Models;

namespace AgendayCliente.Controllers;
public class AgendamentoClienteController : Controller
{
    private static List<NovoCliente> clientes = new List<NovoCliente>();

    // Ação para exibir a lista de Clientes
    public IActionResult Index()
    {
        return View(clientes);
    }

    // Ação para exibir o formulário de criação de clientes
    public IActionResult NovoCliente()
    {
        return View();
    }

    // Ação para lidar com o POST do formulário de criação de clientes
    [HttpPost]
    public IActionResult NovoCliente(NovoCliente cliente)
    {
        cliente.DataCriacao = DateTime.Now;
        clientes.Add(cliente);

        return RedirectToAction("Index");
    }
}
