using System;
using InheritanceExercises.Model;

namespace InheritanceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        static void VehicleTest()
        {
            Car car = new Car(4, 1990, true, "CowClock", "Saab", "Red", 100);
            Motorcycle motorcycle = new Motorcycle(2005, true, "BoomBoom", "GlowMcSub", "Black", 90);
            Truck truck = new Truck(5, false, "LiftLift", "Henrikssubub", "Yellow", 90);

            car.Drive();
            motorcycle.Drive();
            truck.Drive();
        }
    }
}
