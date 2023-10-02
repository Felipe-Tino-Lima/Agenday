using System;
using System.ComponentModel.DataAnnotations;

namespace Argenday.Models
{
    public class Agendamento 
    {
        //Data Annotations
        
        public Agendamento() => CriadoEm = DateTime.Now;
        public int AgendamentoId { get; set; }
        public string Cliente { get; set; }
        public string Cpf { get; set; }
        public string DataAgendamento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}