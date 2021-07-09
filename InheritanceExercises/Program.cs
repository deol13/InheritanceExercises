using System;
using InheritanceExercises.Model;
using InheritanceExercises.BookModel;
using System.Collections.Generic;

namespace InheritanceExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //VehicleTest();
        }

        static void BookTest()
        {
            TeenageBook tBook = new TeenageBook();
            tBook.Title = "Harry Potter & A";
            TeenageBook tBook2 = new TeenageBook();
            tBook2.Title = "Harry Potter & B";
            TeenageBook tBook3 = new TeenageBook();
            tBook3.Title = "Harry Potter & C";
            TeenageBook tBook4 = new TeenageBook();
            tBook4.Title = "Harry Potter & D";

            TeenageBook.AddTeenageBook(tBook);
            TeenageBook.AddTeenageBook(tBook2);
            TeenageBook.AddTeenageBook(tBook3);
            TeenageBook.AddTeenageBook(tBook4);

            List<TeenageBook> t = TeenageBook.GetTeenageBooks();
            foreach (TeenageBook book in t)
            {
                Console.WriteLine($"Title: {book.Title}\nAuthor: {book.Author}\nCategory: {book.Category}\nYear: {book.Year}\nPages: {book.Pages}\n");

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(TeenageBook.SearchTeenageBook("Harry Potter & A") + "\n");
            Console.WriteLine(TeenageBook.SearchTeenageBook("Harry Potter & H"));
        }

        static void VehicleTest()
        {
            Vehicle vehicle = new Vehicle("abc", "mmm", "Pink", 200);
            Car car = new Car(4, 1990, true, "CowClock", "Saab", "Red", 100);
            Motorcycle motorcycle = new Motorcycle(2005, true, "BoomBoom", "GlowMcSub", "Black", 90);
            Truck truck = new Truck(5, false, "LiftLift", "Henrikssubub", "Yellow", 90);

            //Car got override
            Vehicle vehicle2 = new Car(4, 1990, true, "CowClock", "Saab", "Red", 100);
            //Motorcyle and Truck got new
            Vehicle vehicle3 = new Motorcycle(2005, true, "BoomBoom", "GlowMcSub", "Black", 90);
            Vehicle vehicle4 = new Truck(5, false, "LiftLift", "Henrikssubub", "Yellow", 90);


            Console.WriteLine("Vehicle: " + vehicle.Drive()+ "\n");
            
            Console.WriteLine("Car = new Car: " + car.Drive());
            Console.WriteLine("Vehicle = new Car: " + vehicle2.Drive() + "\n");

            Console.WriteLine("Motorcycle = new Motorcycle: " + motorcycle.Drive());
            Console.WriteLine("Vehicle = new Motorcycle: " + vehicle3.Drive() + "\n");

            Console.WriteLine("Truck = new Truck: " + truck.Drive());
            Console.WriteLine("Vehicle = new Truck: " + vehicle2.Drive());
        }
    }
}
