using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_MyClassAndObjects
{
    internal class Shirt
    {
        //decalaration variable
        public string brand;
        public string color;
        public string size;

        //method we use
        public void DisplayInfo()
        {
            Console.WriteLine("\nBrand: "+ brand + "\nColor: "  + color + "\nSize: " +  size);
        }
    }
}
