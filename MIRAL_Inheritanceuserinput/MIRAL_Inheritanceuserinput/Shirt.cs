using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_Inheritanceuserinput
{
    class Shirt//Base class
    {
        //Instannce of a Shirt class
        public string Brand;
        public int Price;
        //Constructor
        public Shirt(string brand, int price)
        {
            Brand = brand;
            Price = price;
        }
        public void ShirtDisplayInfo()//Ceate a method to display shirt Details
        {
            Console.WriteLine("Brandname: \t" + Brand);
            Console.WriteLine("Price: \t\t" + Price);
        }
    }
    class Formal : Shirt//Derived class
    {
        //instance of a formal class
        public string Size;
        public string Color;
        //Constructor
        public Formal(string brand, int price, string size, string color) : base(brand, price)
        {
            Brand = brand;
            Price = price;
            Size = size;
            Color = color;
        }
        public void FormalDisplayInfo()//Create a method to display formal Details
        {
            Console.Clear();
            Console.Write(Environment.NewLine);
            Console.WriteLine("\n----- Formal Shirt Details-----");
            ShirtDisplayInfo();
            Console.WriteLine("Size: \t\t" + Size);
            Console.Write("Color: \t\t" + Color);
        }
    }
    class Casual : Shirt //Derived Class
    {
        //Instance of a Casual class
        public string Fabrictype;
        public string Shirtlenght;
        //Constructor
        public Casual(string brand, int price, string fabrictype, string shirtlenght) : base(brand, price)
        {
            Brand = brand;
            Price = price;
            Fabrictype = fabrictype;
            Shirtlenght = shirtlenght;
        }
        public void CasualDisplayInfo()//Create a method to display Casual Details
        {
            Console.Clear();
            Console.Write(Environment.NewLine);
            Console.WriteLine("\n----- Casual Shirt Details-----");
            ShirtDisplayInfo();
            Console.WriteLine("Fabric Type: \t" + Fabrictype);
            Console.Write("Shirt Lenght: \t" + Shirtlenght);
        }
    }
}
