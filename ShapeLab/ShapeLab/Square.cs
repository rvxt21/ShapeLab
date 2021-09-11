using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLab
{
    class Square:Shape
    {
        public int side;
        public Square(int side,string line_color,int line_thickness) : base(line_color, line_thickness)
        {
            this.side = side;
        }
        public int Side
        {
            get { return side;}
            set { side = value; }
        }
        public void Area()
        {
            Console.WriteLine($"\tПлощадь квадрата={side * side}");
        }
        public void Periemeter()
        {
            Console.WriteLine($"\tПериметр квадрата= {side * 4}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"\tБыл создан квадрат\n Длина стороны:{ side} Цвет линий:{ line_color} Ширина линий:{line_thickness}");
        }
    }
}
