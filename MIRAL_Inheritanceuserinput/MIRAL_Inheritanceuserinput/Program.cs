using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_Inheritanceuserinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            Console.Write(Environment.NewLine);
            Console.WriteLine("Choose a type of shirt that you want to buy");//user can choose what type of shirt they want 
            Console.WriteLine("\t(1)Formal     (2)Casual\n");
            Console.Write("Type of shirt: ");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == '1')
            {
                Console.WriteLine("\n-----Formal Shirt Information-----");
                Console.Write("Enter a Brandname: \t");
                string aBrand = Console.ReadLine();
                Console.Write("Enter a Price:  \t");
                int aPrice = int.Parse(Console.ReadLine());
                Console.Write("Enter a Size:   \t");
                string aSize = Console.ReadLine();
                Console.Write("Enter a Color:  \t");
                string aColor = Console.ReadLine();

                Formal myformal = new Formal(aBrand, aPrice, aSize, aColor);//Instantiate the Formalshirt

                myformal.FormalDisplayInfo();//call the mmethod to display formal details

            }
            else if (ans == '2')
            {
                Console.WriteLine("\n-----Casual Shirt Information-----");
                Console.Write("Enter a Brandname: \t");
                string aBrand = Console.ReadLine();
                Console.Write("Enter a Price:  \t");
                int aPrice = int.Parse(Console.ReadLine());
                Console.Write("Enter a Fabric Type: \t");
                string aFabrictype = Console.ReadLine();
                Console.Write("Enter a Shirt Lenght: \t");
                string aShirtlenght = Console.ReadLine();

                Casual mycasual = new Casual(aBrand, aPrice, aFabrictype, aShirtlenght);//Instantiate the Casualshirt

                mycasual.CasualDisplayInfo();//Call the method to display casual info
            }
            Console.WriteLine();
            Console.Write("\nDo you want to try again(y/n): ");//ask the user if they want to try again
            char ans1 = Convert.ToChar(Console.ReadLine());
            if (ans1 == 'y')
            {
                goto Main;
            }
            else if  (ans1 == 'n')
            {
                return;
            }
              
        }
    }
}
