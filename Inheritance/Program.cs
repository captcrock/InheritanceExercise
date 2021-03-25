using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var burb = new Bird();
            burb.doesFly = true;
            burb.predator = true;
            burb.hourCanFly = 3;
            burb.name = "Eagle";


            var rept = new Reptile();
            rept.hasScales = true;
            rept.monthsActive = 7;
            rept.legs = true;
            rept.commonName = "Lizard";


            Console.WriteLine($"The animals that have been picked are birds: " +
                $"{burb.name} and it can fly {burb.doesFly} for {burb.hourCanFly}" +
                $" hours, but is it a predator? {burb.predator}. \n And for reptiles: " +
                $"{rept.commonName} and it has scales {rept.hasScales} and is active" +
                $"{rept.monthsActive}  months, and it has legs {rept.legs}");
        }
    }
}
