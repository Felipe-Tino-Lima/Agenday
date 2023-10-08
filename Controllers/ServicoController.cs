namespace AgendayServico.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using AgendayMKll.Models;

public class Agenda
{
    private List<Usuario> usuarios = new List<Usuario>();

    public Agenda(List<Usuario> usuarios)
    {
        this.usuarios = usuarios;
    }

    private List<Servico> servicos = new List<Servico>();
    private List<Cliente> clientes = new List<Cliente>();

    public void AdicionarUsuario(Usuario usuario)
    {
        usuario.Id = usuarios.Count + 1;
        usuarios.Add(usuario);
    }

    public void AdicionarServico(Servico servico)
    {
        servico.Id = servicos.Count + 1;
        servicos.Add(servico);
    }

    public void AdicionarCliente(Cliente cliente)
    {
        cliente.Id = clientes.Count + 1;
        clientes.Add(cliente);
    }

    public void ListarUsuarios()
    {
        foreach (var usuario in usuarios)
        {
            Console.WriteLine(value: $"ID: {usuario.Id}, Nome: {usuario.Nome}, Email: {usuario.Email}");
        }
    }

    public void ListarServicos()
    {
        foreach (var servico in servicos)
        {
            Console.WriteLine($"ID: {servico.Id}, Nome: {servico.Nome}, Preço: {GetPreco(servico):C}");
        }
    }

    private static object GetPreco(Servico servico)
    {
        return servico.Preco;
    }

    public void ListarClientes()
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine(value: $"ID: {cliente.Id}, Nome: {cliente.Nome}, Telefone: {cliente.Telefone}");
        }
    }

    public void RemoverUsuario(int id)
    {
        var usuario = usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario != null)
        {
            usuarios.Remove(usuario);
        }
    }

    public void RemoverServico(int id)
    {
        var servico = servicos.FirstOrDefault(s => s.Id == id);
        if (servico != null)
        {
            servicos.Remove(servico);
        }
    }

    public void RemoverCliente(int id)
    {
        var cliente = clientes.FirstOrDefault(c => c.Id == id);
        if (cliente != null)
        {
            clientes.Remove(cliente);
        }
    }
}
