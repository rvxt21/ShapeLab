using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLab
{
    abstract class Shape
    {
        protected string line_color;
        public int line_thickness;

        public Shape()
        {
            Console.WriteLine("Enter line color:");
            line_color = Console.ReadLine();
            Console.WriteLine("Enter line thickness:");
            line_thickness = Convert.ToInt32(Console.ReadLine());
        }
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
        public void Area() { }
        public void Periemeter() { }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Line color:{ line_color}\nLine width:{line_thickness}");
        }

    }
}
