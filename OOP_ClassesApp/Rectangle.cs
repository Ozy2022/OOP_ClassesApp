using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassesApp
{
    internal class Rectangle
    {
        //declaration of the field so this field would be
        //the same for every single instance 
        public const int NumberOfCorners = 4;

        //declaration of reald-only field so this field would be
        //different for every single instance 
        public readonly string Color;

        public Rectangle(string color)
        {
            Color = color;
        }


        //Methd to display the details of the rectangle
        public void DisplayDetails()
        {
            Console.WriteLine($"Color: {Color}, Width: {Width}, Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners} ");
        }


        public double Width { get; set; }
        public double Height { get; set; }


        // Read Only Prop
        public double Area
        {
            get { return Width * Height; } 
        }

    }
}
