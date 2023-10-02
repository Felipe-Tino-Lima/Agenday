using System;
using System.ComponentModel.DataAnnotations;

namespace Agenday.Models
{
    public class Agendamento 
    {
        //Data Annotations
        
        public Agendamento() => CriadoEm = DateTime.Now;
        public int AgendamentoId { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}