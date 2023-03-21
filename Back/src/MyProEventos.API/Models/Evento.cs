using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProEventos.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string EventoLocal { get; set; }
        public string EventoData { get; set; }
        public string EventoTema { get; set; }
        public int EventoQtdPessoas { get; set; }
        public string EventoLote { get; set; }
        public string EventoImagemURL { get; set; }
    }
}