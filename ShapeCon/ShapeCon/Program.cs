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
            
            while(true)
            {
                Console.WriteLine("\nChoose what kind of shape do you want: ");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("\n");
                
                switch(choice)
                {
                    case 1:
                    Console.Write("Enter Name: ");
                    sh.Name = Console.ReadLine();
                    Console.Write("Enter Color: ");
                    sh.Color = Console.ReadLine();
                    Console.Write("Enter No. of Sides: ");
                    sh.NoSide = int.Parse(Console.ReadLine());
                    Console.Write("Enter side Length: ");
                    ((Square)sh).SideLength = double.Parse(Console.ReadLine());
                    Console.Write("\nResult");
                    Console.WriteLine(sh);
                    break;

                    case 2:
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
                    Console.Write("\nResult");
                    Console.WriteLine(sh);
                    break;

                    case 3:
                    sh = new Circle();
                    Console.Write("Enter Name: ");
                    sh.Name = Console.ReadLine();
                    Console.Write("Enter Color: ");
                    sh.Color = Console.ReadLine();
                    Console.Write("Enter  Radius: ");
                    ((Circle)sh).Radius = double.Parse(Console.ReadLine());
                    Console.Write("\nResult");
                    Console.WriteLine(sh);
                    break;

                    case 4:
                    Console.Write("Babye.");
                    return;

                    default:
                    Console.Write("Invalid Choice.");
                    break;
                }
            }
        }
    }
}