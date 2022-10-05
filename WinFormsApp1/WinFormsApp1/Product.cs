using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Product : Ware 
    {
        public string ExpirationDate { get; set; }
        public string Number { get; set; }
        public string Demension { get; set; }

    }
}
