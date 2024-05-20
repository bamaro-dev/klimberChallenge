using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : Idioma
    {
        static readonly Dictionary<string, string> traduccion = new Dictionary<string, string>
        {
            { "Cuadrado", "Square" },
            { "CuadradoPlural", "Squares" },
            { "Circulo", "Circle" },
            { "CirculoPlural", "Circles" },
            { "TrianguloEquilatero", "Triangle" },
            { "TrianguloEquilateroPlural", "Triangles" },
            { "Trapecio", "Trapezoid" },
            { "TrapecioPlural", "Trapezoids" },
            { "Rectangulo", "Rectangle" },
            { "RectanguloPlural", "Rectangles" },
            { "Listavaciadeformas", "Empty list of shapes!" },
            { "ReportedeFormas", "Shapes report" },
            { "TOTAL", "TOTAL" },
            { "formas", "shapes" },
            { "Perimetro", "Perimeter" },
            { "Area", "Area" }
        };

        public Ingles() : base(traduccion)
        { }

    }
}
