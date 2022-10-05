using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Mountain : IGeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public double TheHighestPoint { get; set; }

        public Mountain(double x, double y, string name, string description, double theHighestPoint)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            TheHighestPoint = theHighestPoint;
        }
        public void displayInformation()
        {
            Console.WriteLine("The coordinates are X = " + X + " Y = " + Y);
            Console.WriteLine("The name of object is " + Name);
            Console.WriteLine("The description is " + Description);
            Console.WriteLine("The Highest point is " + TheHighestPoint);
        }
    }
}
