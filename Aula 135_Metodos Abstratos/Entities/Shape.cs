using System;
using System.Collections.Generic;
using System.Text;
using Aula_135_Metodos_Abstratos.Entities.Enums;

namespace Aula_135_Metodos_Abstratos.Entities
{
     abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();        
    }
}
