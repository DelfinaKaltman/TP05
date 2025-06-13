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
            respuestasCorrectas = new List<string>{"puerta principal", "inter de milan", "3241", "MVC", "71612"};
            numeroSala = 1;
            pistas = new List<string>{"Estoy al frente y todos deben pasar por mí. No soy camino… ¿qué soy?", "Lautaro Martínez se fue a este equipo, después de jugar en Racing", "Vestite de arriba para abajo", "Son tres letras, Delfi ya contó chistes sobre esto", "Las posiciones de las letras de GOL en el abecedario"};
        }

        public void comprobarRespuesta(string respuesta)
        {
            respuesta = respuesta.ToLower();
            string respuestaCorrecta = respuestasCorrectas[numeroSala - 1].ToLower();
            
                if (respuesta == respuestaCorrecta)
                {
                    numeroSala++;
                } 
        }

        public string pedirPista()
        { return pistas[numeroSala - 1]; }
    }
}

