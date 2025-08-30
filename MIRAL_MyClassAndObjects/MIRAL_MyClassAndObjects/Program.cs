using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_MyClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MYLENE I. MIRAL
            //IT306
            //Create a Class


            //instantiation an object 
            Shirt shirt1 = new Shirt();
           Shirt shirt2 = new Shirt();

            //Initialize the value of the fields
            shirt1.brand = "Calvin Klein";
            shirt1.color = "White";
            shirt1.size = "s";

            shirt2.brand = "Lacoste";
            shirt2.color = "Black";
            shirt2.size = "xs";

            //Call the method to diplay information bellow
            Console.WriteLine("These are my favorite shirt: ");
            shirt1.DisplayInfo();
            shirt2.DisplayInfo();


            Console.ReadKey();
        }
    }
}
