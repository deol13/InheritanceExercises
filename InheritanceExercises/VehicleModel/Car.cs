using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.Model
{
    public class Car : Vehicle
    {
        public readonly int nrOfSets;
        public readonly int year;
        public readonly bool towbar;

        public Car(int nrOfSets, int year, bool towbar,
                   string model, 
                   string brand,
                   string color,
                   int horsePowers) : base(model, brand, color, horsePowers)
        {
            this.nrOfSets = nrOfSets;
            this.year = year;
            this.towbar = towbar;
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
