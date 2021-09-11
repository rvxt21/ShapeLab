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
        public virtual void Area()
        {
            Console.WriteLine($"\tSquare area={side * side}");
        }
        public virtual void Periemeter()
        {
            Console.WriteLine($"\tPeriemeter of a square= {side * 4}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"\tA square was created\nSide length:{ side}\nColor lines:{ line_color}\nLine width:{line_thickness}");
        }
    }
}
