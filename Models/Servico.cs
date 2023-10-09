
namespace Agenday.Models;
public class Servico
{
    public int ServicoId { get; set; }
    public string? Nome { get; set; }

    public string Cliente {get;set; }

    public string Usuario {get; set ;}

    public int Preco { get; internal set; }
}

