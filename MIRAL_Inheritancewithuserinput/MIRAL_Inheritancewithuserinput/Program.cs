using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_Inheritancewithuserinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Shirt do you want");
                Console.WriteLine("1.PoloShirt or 2.Casual Shirt");
            Console.WriteLine("Enter a Choice (1 or 2):");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the brand do you want: ");
                string brand= Console.ReadLine();
            }




        }
    }
}
