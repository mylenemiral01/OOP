using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_CaO
{
    // Mylene I. Miral
    // IT306
    // Creating a class 
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "Mylene I. Miral";
            person1.age = 18;
            person1.gender = "female";

            //call the method
            person1.Greet();
            Console.ReadKey();


        }
    }
}
