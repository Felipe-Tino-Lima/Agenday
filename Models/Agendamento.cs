namespace Agenday.Models;

    public class Agendamentos
    {
        //Data Annotations
        
        public Agendamentos() => CriadoEm = DateTime.Now;
        public int AgendamentoId { get; set; }
        public DateTime CriadoEm { get; set; }
    }
