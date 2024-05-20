using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Idioma
    {
        Dictionary<string, string> traduccion;
        public Idioma(Dictionary<string, string> t) {
            traduccion = t;
        }
        //public abstract string Traducir(string palabra);
        //public abstract string TraducirForma(string forma, int cantidad);

        public string Traducir(string palabra)
        {
            return traduccion.ContainsKey(palabra) ? traduccion[palabra] : "No encontrado";
        }

        public string TraducirForma(string forma, int cantidad)
        {
            return traduccion.ContainsKey(forma) ? (cantidad == 1 ? traduccion[forma] : traduccion[forma + "Plural"]) : "No encontrado";
        }
    }
}
