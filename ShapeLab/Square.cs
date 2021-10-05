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
        public Square()
        {
            Console.WriteLine("Enter side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int Side
        {
            get { return side;}
            set { side = value; }
        }
        public void Area()
        {
            Console.WriteLine($"\tSquare area={side * side}");
        }
        public void Periemeter()
        {
            Console.WriteLine($"\tPeriemeter of a square= {side * 4}");
        }
        public override void GetInfo()
        {
            Console.WriteLine($"\tA square was created\nSide length:{ side}\nColor lines:{ line_color}\nLine width:{line_thickness}");
        }
    }
}
