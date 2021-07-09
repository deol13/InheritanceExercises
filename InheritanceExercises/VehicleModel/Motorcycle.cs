using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.Model
{
    public class Motorcycle : Vehicle
    {
        public readonly int year;
        public readonly bool bagspace;

        public Motorcycle(int year, bool bagspace,
                   string model,
                   string brand,
                   string color,
                   int horsePowers) : base(model, brand, color, horsePowers)
        {
            this.year = year;
            this.bagspace = bagspace;
        }

        public new string Drive()
        {
            return "Motorcycle.";
        }
    }
}
