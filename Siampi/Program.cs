
using System.Runtime.Intrinsics.Arm;

namespace Siampi
{
    class Program
    {
        static void Main(string[] args)
        {

            Car siampiCar = new Car();
    

            siampiCar.Color = "Orange";
            siampiCar.Model = "Chery";
            siampiCar.Seats = 5;


            Console.WriteLine($"Siampi's car color is {siampiCar.Color}.");
            Console.WriteLine($"Siampi's car model is {siampiCar.Model}.");
            Console.WriteLine($"Siampi's car seat has {siampiCar.Seats} seat.");

            Car nunuCar = new Car();

            nunuCar.Color = "Yellow";
            nunuCar.Model = "Toyota";
            nunuCar.Seats = 4;
            nunuCar.Safetyrate = 5;


            Console.WriteLine($"Nunu's car color is {nunuCar.Color}.");
            Console.WriteLine($"Nunu's car model is {nunuCar.Model}.");
            Console.WriteLine($"Nunu's car seat has {nunuCar.Seats} seat.");
            Console.WriteLine($"Nunu's car safety rate is {nunuCar.Safetyrate} star.");

            Car papaCar = new Car();

            papaCar.Color = "Green";
            papaCar.Model = "Honda";
            papaCar.Seats = 7;
            papaCar.Safetyrate = 3;


            Console.WriteLine($"Papa's car color is {papaCar.Color}.");
            Console.WriteLine($"Papa's car model is {papaCar.Model}.");
            Console.WriteLine($"Papa's car seat has {papaCar.Seats} seat.");
            Console.WriteLine($"Papa's car safety rate is {papaCar.Safetyrate} star.");

          





        }
        
    }    
    
}