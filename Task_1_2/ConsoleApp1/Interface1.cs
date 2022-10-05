using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
   internal interface  IGeographicalObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get;set; }
        void displayInformation();
    }
}
