using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : Idioma
    {
        static readonly Dictionary<string, string> traduccion = new Dictionary<string, string>
        {
            { "Cuadrado", "Quadrato" },
            { "CuadradoPlural", "Quadrati" },
            { "Circulo", "Cerchio" },
            { "CirculoPlural", "Cerchi" },
            { "TrianguloEquilatero", "Triangolo" },
            { "TrianguloEquilateroPlural", "Triangoli" },
            { "Trapecio", "Trapezio" },
            { "TrapecioPlural", "Trapezi" },
            { "Rectangulo", "Rettangolo" },
            { "RectanguloPlural", "Rettangoli" },
            { "Listavaciadeformas", "Elenco vuoto di moduli!" },
            { "ReportedeFormas", "Rapporto sui moduli" },
            { "TOTAL", "TOTALE" },
            { "formas", "moduli" },
            { "Perimetro", "Perimetro" },
            { "Area", "Area" }
        };

        public Italiano() : base(traduccion)
        { }

    }
}
