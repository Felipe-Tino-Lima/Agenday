using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AgendayCliente.Models;

namespace AgendayCliente.Controllers;
public class AgendamentoClienteController : Controller
{
    private static List<NovoCliente> clientes = new List<NovoCliente>();

    // Ação para exibir a lista de agendamentos
    public IActionResult Index()
    {
        return View(clientes);
    }

    // Ação para exibir o formulário de criação de agendamento
    public IActionResult NovoCliente()
    {
        return View();
    }

    // Ação para lidar com o POST do formulário de criação
    [HttpPost]
    public IActionResult NovoCliente(NovoCliente cliente)
    {
        cliente.DataCriacao = DateTime.Now;
        clientes.Add(cliente);

        return RedirectToAction("Index");
    }
}
