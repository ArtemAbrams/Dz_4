using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Book : Ware
    {
        public string numberOfPages { get; set; }
        public string PublishingHouse { get; set;}
        public string Authors { get; set; } 
    }
}
