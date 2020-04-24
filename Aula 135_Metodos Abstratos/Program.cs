using System;
using System.Collections.Generic;
using Aula_135_Metodos_Abstratos.Entities;
using Aula_135_Metodos_Abstratos.Entities.Enums;
using System.Globalization;
    
namespace Aula_135_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shape = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data");
                Console.Write("Rectangle or Cicle (r/c)? ");
                char geo = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                
                if (geo == 'r')
                {
                    Console.Write("Widht: ");
                    double w = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double h = double.Parse(Console.ReadLine());
                    shape.Add(new Rectangle(w, h, color));
                }
                else if (geo == 'c')
                {
                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine());
                    shape.Add(new Circle(r, color));
                }
                else
                {
                    Console.WriteLine("Wrong chose option!");
                }               
            }
            Console.WriteLine();
            Console.WriteLine("SHAPES AREAS");
            foreach (Shape area in shape)
            {
                Console.WriteLine(area.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
