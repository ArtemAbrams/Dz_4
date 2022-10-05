using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    public class River: IGeographicalObject
    { 
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Speed {get; set; }
        public double Length {get; set; }

        public River(double x, double y, string name, string description, double speed, double length)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            Speed = speed;
            Length = length;
        }
        public void displayInformation()
        {
            Console.WriteLine("The coordinates are X = " + X + " Y = " + Y);
            Console.WriteLine("The name of object is " + Name);
            Console.WriteLine("The description is " + Description);
            Console.WriteLine("The speed is " + Speed);
            Console.WriteLine("The length is " + Length);
        }
    }
}
