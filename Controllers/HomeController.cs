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

        public IActionResult InicializarPartida()
    {
        Partida partida = new Partida();
        return View("Juego");
    }

    public IActionResult Sala1()
    {
        ViewBag.respuesta = Partida.comprobarRespuesta();
        ViewBag.pistas = Partida.pedirPista();
        return View("Sala1");
    }

    public IActionResult Sala2()
    {
        ViewBag.respuesta = Partida.comprobarRespuesta();
        ViewBag.pistas = Partida.pedirPista();
        return View("Sala2");
    }

    public IActionResult Sala3()
    {
        ViewBag.respuesta = Partida.comprobarRespuesta();
        ViewBag.pistas = Partida.pedirPista();
        return View("Sala3");
    }

    public IActionResult Sala4()
    {
        ViewBag.respuesta = Partida.comprobarRespuesta();
        ViewBag.pistas = Partida.pedirPista();
        return View("Sala4");
    }

    public IActionResult Sala5()
    {
        ViewBag.respuesta = Partida.comprobarRespuesta();
        ViewBag.pistas = Partida.pedirPista();
        return View("Sala5");
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
