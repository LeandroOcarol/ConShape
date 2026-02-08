using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCon
{
    internal class Circle:Shape
    {
        private double radius;

        public Circle() { }

        public Circle(string name, string color, int noSide, double radius)
        {
            base.Name = name;
            base.Color = color;
            base.NoSide = noSide;
            this.Radius = radius;
            
        }

        public double Radius { get => radius; set => radius = value; }

        public override string ToString()
        {

            return "\nName: " + base.Name +
                "\nColor: " + base.Color +
                "\nRadius: " + this.Radius +
                "\nArea of the Square: " + this.ComputeArea() +
                "\n";
        }

        public override double ComputeArea() {
            
            return Math.PI * Math.Pow(this.radius,2);
        }
    }
}
