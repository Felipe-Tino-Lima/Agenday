namespace AgendayMKll.Models;
public class Usuario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public object? Email { get; internal set; }
}

public class Servico
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public object? Preco { get; internal set; }
}

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public object? Telefone { get; internal set; }
}
