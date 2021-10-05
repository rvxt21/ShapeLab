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
        public new void Area()
        {
            Console.WriteLine($"\tRectangle area={side * lenght}");
        }
        public new void Periemeter()
        {
            Console.WriteLine($"\tPerimeter of a rectangle= {(side + lenght) * 2}");
        }
        public override void GetInfo()
        {
            Console.WriteLine($"\tA rectangle was created\nLenght:{side}\nHeight of the rectangle:{lenght}\nLine color:{ line_color}\nLine width:{line_thickness}");
        }
    }
}
