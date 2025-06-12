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


    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }

    public IActionResult Créditos()
    {
        return View("Credito");
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
        partida.comprobarRespuesta(respuesta);
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(partida));
        return View("Sala"+partida.numeroSala);
    }

    public IActionResult PedirPista()
    {
        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("juego"));
        partida.pedirPista();
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(partida));
        return View("Pistas");
    }


    public IActionResult Resultado(int numeroSala, string respuesta)
    {
        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("juego"));
        partida.comprobarRespuesta(respuesta);
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(partida));

        if(numeroSala >= 5) 
        {
            return View("Resultado");
        } 
        else
        {
            return View("Sala"+partida.numeroSala);
        }
    }
}
