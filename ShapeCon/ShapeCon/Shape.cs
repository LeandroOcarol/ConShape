using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCon
{
    internal class Shape
    {
        private string name;

        

        private string color;
        private int noSide;

        public Shape() { }
        public Shape(string name, string color, int noSide)
        {
            this.Name = name;
            this.Color = color;
            this.NoSide = noSide;
        }

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int NoSide { get => noSide; set => noSide = value; }

        public override string ToString()
        {
            return "\nName: " + this.Name +
                "\nColor: " + this.Color +
                "\nNo. of Side: " + this.NoSide +
                "\nArea of a Shape: " + this.ComputeArea;
        }

        public virtual double ComputeArea()
        {
            return 0.0;
        }

    }
}
