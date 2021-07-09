using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.Model
{
    /// <summary>
    /// Base class
    /// </summary>
    public class Vehicle
    {
        public readonly string model;
        public readonly string brand;
        public readonly string color;
        public readonly int horsePowers;
        public readonly int year;

        public Vehicle(string model, string brand, string color, int horsePowers, int year)
        {
            this.model = model;
            this.brand = brand;
            this.color = color;
            this.horsePowers = horsePowers;
            this.year = year;
        }
    }
}
