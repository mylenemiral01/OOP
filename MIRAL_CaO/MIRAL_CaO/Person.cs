using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_CaO
{
    internal class Person
    {
        //Class Members: 
        public string name;
        public int age;
        public string gender;

        // 
        public void Greet() 
        { 
            Console.WriteLine(" Hi everyone good day, I'm " + name + " "+ age  + " years old and I'm a " + gender + " person.");
        }

    }
}
