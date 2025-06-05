using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TP04.Models
{
    public class Partida
    {
        [JsonProperty]
        public static string nombre { get; private set; }
        [JsonProperty]
        public static Dictionary<string> respuestasCorrectas { get; private set; }
        [JsonProperty]
        public static int numeroSala { get; private set; }
        [JsonProperty]
        public static Dictionary<string> pistas { get; private set; }

        
        public Partida (string nombre, int numeroSala)
        {
            pNombre = nombre;
            respuestasCorrectas = new Dictionary<string>{"puerta principal", "inter", 3241, "MVC", "71612"};
            pNumeroSala = numeroSala;
            pistas = new Dictionary<string>{"Estoy al frente y todos deben pasar por mí. No soy camino… ¿qué soy?", "Lautaro Martínez se fue a este equipo, después de jugar en Racing", "Vestite de abajo para arriba", "Son tres letras, delfi ya contó chistes sobre esto", "L abre el acertijo, G va caminando al lado, y O lo cierra encantado. Si a cada letra le das su lugar, ¿qué tres números vas a anotar?"};
        }

        public static void Sala(string respuesta)
        {
            respuesta = string.ToLower(respuesta);
            if (respuestasCorrectas.ContainsKey(numeroSala))
            {
                if (respuesta == respuestasCorrectas[numeroSala])
                {
                    numeroSala++;
                }
            }
        }

            public string PedirPista()
        { return pistas[numeroSala - 1]; }
    }
}

