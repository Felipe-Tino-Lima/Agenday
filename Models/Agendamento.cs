namespace Agenday.Models;

    public class Agendamentos
    {
        //Data Annotations
        
        public Agendamentos() => AgendadoEm = DateTime.Now;
        public int AgendamentoId { get; set; }

        public int Usuario {get; set;}

        public DateTime AgendadoEm { get; set; }
    }
