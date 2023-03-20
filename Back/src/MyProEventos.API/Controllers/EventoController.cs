using System;
using Microsoft.AspNetCore.Mvc;
using MyProEventos.API.Models;

namespace MyProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        [HttpGet]
        public Evento Get() => new Evento() {
            EventoId = 1,
            Tema = "Novo Tema",
            Local = "Rio de Janeiro",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString()
        };
    }
}