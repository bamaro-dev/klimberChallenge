/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        private readonly decimal _lado;

        public FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{idioma.Traducir("Listavaciadeformas")}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{idioma.Traducir("ReportedeFormas")}</h1>");

                Dictionary<string, (int cantidad, decimal totalPerimetro, decimal totalArea)> reporte = new Dictionary<string, (int, decimal, decimal)>();

                foreach (var f in formas)
                {
                    string tipo = f.GetType().Name;
                    decimal perimetro = f.CalcularPerimetro();
                    decimal area = f.CalcularArea();

                    if (reporte.ContainsKey(tipo))
                    {
                        var (cantidad, totalPerimetro, totalArea) = reporte[tipo];
                        reporte[tipo] = (cantidad + 1, totalPerimetro + perimetro, totalArea + area);
                    }
                    else
                    {
                        reporte[tipo] = (1, perimetro, area);
                    }
                }

                int cantidadTotal = 0;
                decimal perimetroTotal = 0;
                decimal areaTotal = 0;
                foreach (var f in reporte)
                {
                    sb.Append(ObtenerLinea(f.Value.cantidad, f.Value.totalArea, f.Value.totalPerimetro, f.Key, idioma));
                    cantidadTotal = cantidadTotal + f.Value.cantidad;
                    perimetroTotal = perimetroTotal + f.Value.totalPerimetro;
                    areaTotal = areaTotal + f.Value.totalArea;
                }

                // FOOTER
                sb.Append($"{idioma.Traducir("TOTAL")}:<br/>");
                sb.Append($"{cantidadTotal} {idioma.Traducir("formas")} ");
                sb.Append($"{idioma.Traducir("Perimetro")} {perimetroTotal.ToString("#.##")} ");
                sb.Append($"Area {areaTotal.ToString("#.##")}");
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, Idioma idioma)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {idioma.TraducirForma(tipo, cantidad)} | {idioma.Traducir("Area")} {area:#.##} | {idioma.Traducir("Perimetro")} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public abstract decimal CalcularPerimetro();
        public abstract decimal CalcularArea();
    }
}
