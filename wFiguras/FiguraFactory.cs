using System;
using System.Drawing;

namespace wFiguras
{
    public static class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Point posicion, Color color)
        {
            switch (tipo)
            {
                case "Rectangulo":
                    return new Rectangulo(posicion, color, 80, 50);

                case "Circulo":
                    return new Circulo(posicion, color, 30);

                case "Triangulo":
                    return new Triangulo(posicion, color, 60, 50);

                case "Linea":
                    return new Linea(posicion, color);

                default:
                    throw new ArgumentException("Figura no válida.");
            }
        }
    }
}