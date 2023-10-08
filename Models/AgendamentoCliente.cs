namespace Agenday.Models;

public class NovoCliente
{
    public int ClienteID { get; set; }
    public string? Nome { get; set; }
    public string? Genero { get; set; }
    public string? CPF { get; set; }
    public string? Contato { get; set; }
    public DateTime DataCriacao { get; set; }
}
