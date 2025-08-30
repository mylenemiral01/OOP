using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_COConstructorUserInput
{
    internal class Shirt
    {
        //
        public string brand;
        public string color;
        public string size;

        public Shirt(string aBrand,string aColor,string aSize)
        {
            brand = aBrand;
            color = aColor;
            size = aSize;
        }
        public void DisplayShirtDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("----shirt details Area----");
            Console.WriteLine("Brand Name: \t" + brand);
            Console.WriteLine("Color: \t\t" + color);
            Console.WriteLine("Size: \t\t" + size);

        }


    }
}
