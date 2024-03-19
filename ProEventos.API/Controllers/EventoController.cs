using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly DataContext _context;

    public IEnumerable<Evento> eventos { get; set; }
    public EventoController(DataContext context)
    {
        eventos = new List<Evento>() {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11",
                Local = "Curitiba",
                Lote = "1º lota",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToShortDateString()
            },
            new Evento() {
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "Curitiba",
                Lote = "2º lota",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToShortDateString()
            }
        };
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento Get(int id)
    {
        return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
    }

    [HttpPost("{id}")]
    public string Post(int id)
    {
        return "Value";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return "Value";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return "Value";
    }
}
