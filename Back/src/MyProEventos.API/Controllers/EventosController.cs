using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyProEventos.API.Data;
using MyProEventos.API.Models;

namespace MyProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext context;

        public EventosController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get() {
            return context.Eventos;
        }
    }
}