using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TP05.Models
{
    public class Partida
    {
        [JsonProperty]
        public string nombre { get; private set; }
        [JsonProperty]
        public List<string> respuestasCorrectas { get; private set; }
        [JsonProperty]
        public int numeroSala { get; private set; }
        [JsonProperty]
        public List<string> pistas { get; private set; }

        
        public Partida (string pNombre)
        {
            nombre = pNombre;
            respuestasCorrectas = new List<string>{"puerta principal", "inter", "3241", "MVC", "71612"};
            numeroSala = 1;
            pistas = new List<string>{"Estoy al frente y todos deben pasar por mí. No soy camino… ¿qué soy?", "Lautaro Martínez se fue a este equipo, después de jugar en Racing", "Vestite de abajo para arriba", "Son tres letras, delfi ya contó chistes sobre esto", "L abre el acertijo, G va caminando al lado, y O lo cierra encantado. Si a cada letra le das su lugar, ¿qué tres números vas a anotar?"};
        }

        public void comprobarRespuesta(string respuesta)
        {
            respuesta = respuesta.ToLower();
            
                if (respuesta == respuestasCorrectas[numeroSala])
                {
                    numeroSala++;
                } 
        }

        public string pedirPista()
        { return pistas[numeroSala - 1]; }
    }
}

