using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.Model
{
    public class Truck : Vehicle
    {

        public Truck(string model,
                   string brand,
                   string color,
                   int horsePowers,
                   int year) : base(model, brand, color, horsePowers, year)
        {

        }
    }
}
