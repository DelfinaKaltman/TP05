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

        
        public Partida (string respuesta)
        {
            respuestasCorrectas = new Dictionary<string>{"puerta principal", "inter", 3241, "MVC", "71612"};
            sala = 0;
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
    }
}

