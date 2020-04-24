using System;
using System.Collections.Generic;
using System.Text;

using Aula_135_Metodos_Abstratos.Entities.Enums;
namespace Aula_135_Metodos_Abstratos.Entities
{
    class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }        
        public Rectangle(double widht, double height, Color color) : base(color)
        {
            Widht = widht;
            Height = height;            
        }
        public override double Area()
        {
            return Widht * Height;
        }
    }
}
