using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.Model
{
    /// <summary>
    /// Base class
    /// </summary>
    public abstract class Vehicle
    {
        public readonly string model;
        public readonly string brand;
        public readonly string color;
        public readonly int horsePowers;

        public Vehicle(string model, string brand, string color, int horsePowers)
        {
            this.model = model;
            this.brand = brand;
            this.color = color;
            this.horsePowers = horsePowers;
        }

        public abstract void Drive();
    }
}
