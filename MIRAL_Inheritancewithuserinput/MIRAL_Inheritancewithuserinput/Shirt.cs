using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_Inheritancewithuserinput
{
    class Shirt
    { 
      public string Brand { get; set; }
      public string Price { get; set; }

      public void ShirtInfo()
        {
            Console.WriteLine("----Shirt Information----");
            Console.WriteLine("Brandname: " + Brand);
            Console.WriteLine("Price: " + Price);
        }
    }

    class Formal : Shirt
    {
        public string Color { get; set; }   

        public void FormalInfo()
        {
            ShirtInfo();
            Console.WriteLine("Color: " + Color);
        }
    }

    class Casual : Shirt
    {
        public string Size { get; set; }

        public void CasualInfo()
        {
            ShirtInfo();
            Console.WriteLine("Size: " + Size);
        }
    }

}
