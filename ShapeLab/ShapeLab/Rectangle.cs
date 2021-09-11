using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLab
{
    class Rectangle:Square
    {
  
        private int lenght;
        public Rectangle(int lenght,int side,string line_color,int line_thickness) : base(side,line_color,line_thickness)
        {
            this.lenght = lenght;
        }
        public int Side
        {
            get { return side; }
            set { Side = value; }
        }
        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
        public void Area()
        {
            Console.WriteLine($"\tПлощадь прямоугольника={side * lenght}");
        }
        public void Periemeter()
        {
            Console.WriteLine($"\tПериметр прямоугольника= {(side + lenght) * 2}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"\tБыл создан прямоугольник\n Длина:{side} Высота прямоугольника:{lenght} Цвет линий:{ line_color} Ширина линий:{line_thickness}");
        }
    }
}
