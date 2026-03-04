using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siampi
{
    public class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public int Safetyrate { get; set; }

        public void MyMethod(string name, int age)
        {
            Console.WriteLine("I just got executed");
            Console.WriteLine($"My name is {name} and I am {age} years old.");
        }

        public int MathOperation(int x, int y)
        {
            // addition
            //var result = x + y; 
            var result = x * y / x;
           

            return result;
        }


    }
}
