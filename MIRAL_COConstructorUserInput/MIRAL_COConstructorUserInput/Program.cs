using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_COConstructorUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //MYLENE I. MIRAL
        //IT306
        //EXER_03: User Input with Constructor

        Main:
            Console.Clear();
            Console.WriteLine("This program will ask about your favorite shirt.\n");
            Console.Write("Enter a brand of shirt: \t");
            string aBrand=Console.ReadLine();
            Console.Write("Enter a color of shirt: \t");
            string aColor=Console.ReadLine();
            Console.Write("Eneter a size:    \t\t");
            string aSize=Console.ReadLine();

            //
            Shirt shirt1 = new Shirt(aBrand, aColor, aSize);

            //
            shirt1.DisplayShirtDetails();

            //
            Console.Write("\n Do you want to try again (y/n)? ");
            char ans=Convert.ToChar(Console.ReadLine());
            if (ans == 'y')
            {
                goto Main;
            }
            else if(ans == 'n')  
           {
                return;
           }

            
            
        }
    }
}
