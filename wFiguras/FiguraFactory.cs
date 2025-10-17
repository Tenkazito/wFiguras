using System;
using System.Drawing;

namespace wFiguras
{
    public static class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Point posicion, Color color, Point posicion2, int tamaño)
        {
            switch (tipo)
            {
                case "Rectangulo":
                    return new Rectangulo(posicion, color, tamaño);

                case "Circulo":
                    return new Circulo(posicion, color, tamaño);

                case "Triangulo":
                    return new Triangulo(posicion, color, tamaño);

                case "Linea":
                    return new Linea(posicion, color, posicion2);

                default:
                    throw new ArgumentException("Figura no válida.");
            }
        }
    }
}