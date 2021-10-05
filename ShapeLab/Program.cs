
using System;

namespace ShapeLab
{
    
        class Program
        {
            static void Main(string[] args)
            {
                
                Rectangle shape1 = new Rectangle(12, 12, "red", 12);
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


