using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCon
{
    internal class Program
    { 
        static void Main(string[] args) { 

            Shape sh = new Square();
            
            Console.Write("Enter Name: ");
            sh.Name = Console.ReadLine();
            Console.Write("Enter Color: ");
            sh.Color = Console.ReadLine();
            Console.Write("Enter No. of Sides: ");
            sh.NoSide = int.Parse(Console.ReadLine());
            Console.WriteLine(sh);
            Console.Write("Enter side Length: ");
            ((Square)sh).SideLength = double.Parse(Console.ReadLine());
            Console.WriteLine(sh);

            sh = new Rectangle();
            Console.Write("Enter Name: ");
            sh.Name = Console.ReadLine();
            Console.Write("Enter Color: ");
            sh.Color = Console.ReadLine();
            Console.Write("Enter No. of Sides: ");
            sh.NoSide = int.Parse(Console.ReadLine());
            Console.Write("Enter  Length: ");
            ((Rectangle)sh).Length = double.Parse(Console.ReadLine());
            Console.Write("Enter  Width: ");
            ((Rectangle)sh).Width = double.Parse(Console.ReadLine());
            Console.WriteLine(sh);

            sh = new Circle();
            Console.Write("Enter Name: ");
            sh.Name = Console.ReadLine();
            Console.Write("Enter Color: ");
            sh.Color = Console.ReadLine();
            Console.Write("Enter No. of Sides: ");
            sh.NoSide = int.Parse(Console.ReadLine());
            Console.Write("Enter  Radius: ");
            ((Circle)sh).Radius = double.Parse(Console.ReadLine());
            
        }
    }
}