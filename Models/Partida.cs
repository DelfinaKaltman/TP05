using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TP04.Models
{
    public class Ahorcado
    {
        [JsonProperty]
        public static string nombre { get; private set; }
        [JsonProperty]
        public static string respuestaCorrecta { get; private set; }

        [JsonProperty]
        public static string respuesta { get; private set; }
        [JsonProperty]
        public static int sala { get; private set; }
        
        public static void Sala1(string respuesta)
        {
                respuestaCorrecta = "puerta principal";
                respuesta = string.ToLower(respuesta);

            if(respuesta == respuestaCorrecta){

            }



        }
        public static string ArriesgarLetra(char letra)
        {
            string intentoPalabra = null;
            letra = Char.ToLower(letra);
            if(!letrasUsadas.Contains(letra))
            {
                letrasUsadas.Add(letra);
                intentos++;
            }
            intentoPalabra = ArmarPalabra();
	    return intentoPalabra;
        }

        public static string ArmarPalabra()
        {
            string resultado = "";
            foreach (char c in palabraElegida)
            {
                if (letrasUsadas.Contains(c))
                {
                    resultado += c;
                }
                else
                {
                    resultado += "_";
                }
            }
			return resultado;
        }
    }
}