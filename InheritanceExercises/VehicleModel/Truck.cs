using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.Model
{
    public class Truck : Vehicle
    {
        public readonly bool sleepPlace;
        public readonly int tonItCanHandle;

        public Truck(int tonItCanHandle, bool sleepPlace,
                   string model,
                   string brand,
                   string color,
                   int horsePowers) : base(model, brand, color, horsePowers)
        {
            this.tonItCanHandle = tonItCanHandle;
            this.sleepPlace = sleepPlace;
        }

        public new string Drive()
        {
            return "Truck.";
        }
    }
}
