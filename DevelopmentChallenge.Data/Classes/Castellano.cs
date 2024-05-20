using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Castellano : Idioma
    {
        static readonly Dictionary<string, string> traduccion = new Dictionary<string, string>
        {
            { "Cuadrado", "Cuadrado" },
            { "CuadradoPlural", "Cuadrados" },
            { "Circulo", "Círculo" },
            { "CirculoPlural", "Círculos" },
            { "TrianguloEquilatero", "Triángulo" },
            { "TrianguloEquilateroPlural", "Triángulos" },
            { "Trapecio", "Trapecio" },
            { "TrapecioPlural", "Trapecios" },
            { "Rectangulo", "Rectángulo" },
            { "RectanguloPlural", "Rectángulos" },
            { "Listavaciadeformas", "Lista vacía de formas!" },
            { "ReportedeFormas", "Reporte de Formas" },
            { "TOTAL", "TOTAL" },
            { "formas", "formas" },
            { "Perimetro", "Perimetro" },
            { "Area", "Area" }
        };

        public Castellano() : base(traduccion)
        { }

    }
}
