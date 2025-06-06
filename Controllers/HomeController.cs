using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05.Models;

namespace TP05.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult JuegoSession()
    {
       
    }

    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }

        public IActionResult InicializarPartida(string nombre)
    {
        Partida partida = new Partida(nombre);
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(partida));


        return View("Sala1");
    }


    public IActionResult PasarDeSala(string respuesta)
    {
        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("juego"));
        ViewBag.respuesta = partida.comprobarRespuesta(respuesta);
        ViewBag.pistas = partida.pedirPista();
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(partida));
        return View("Sala"+partida.numeroSala);
    }



    public IActionResult Resultado()
    {
        ViewBag.resultado = Partida.comprobarRespuesta();
        ViewBag.pistas = Partida.pedirPista();
        if(numeroSala >= 5) 
        {
            return View("Resultado");
        }
    }
}
