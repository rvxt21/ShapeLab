
using System;

namespace ShapeLab
{
    class Shape
    {
        protected string line_color;
        protected int line_thickness;

        public Shape(string line_color, int line_thickness)
        {
            this.line_color = line_color;
            this.line_thickness = line_thickness;
        }
        public String Line_color
        {
            get { return line_color; }
            set { line_color = value; }
        }
        public int Line_thickness
        {
            get { return line_thickness; }
            set { line_thickness = value; }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Цвет линий:{ line_color}  Ширина линий:{line_thickness}");
        }
        class Program
        {
            static void Main(string[] args)
            {
                Shape square2 = new Shape("blue", 7436);
                square2.GetInfo();
                
                Rectangle shape1 = new Rectangle(12,12,"red",12);
               
                shape1.GetInfo();
                shape1.Periemeter();
                shape1.Area();
                Square shape3 = new Square(12, "red", 282);
                shape3.GetInfo();
                shape3.Periemeter();
                shape3.Area();
                Console.ReadLine();

            }
        }
    }
}

