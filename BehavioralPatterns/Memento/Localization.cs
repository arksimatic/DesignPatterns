using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Memento
{
    //you can also add "caretaker" for keeping all those snapshot (ctrl+z)
    class Localization
    {
        public string City { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Localization(string city, int x, int y)
        {
            this.City = city;
            this.X = x;
            this.Y = y;
        }

        public LocalizationSnapshot CreateSnapshot()
        {
            return new LocalizationSnapshot(this, City, X, Y);
        }

        public override string ToString()
        {
            return $"{City}, {X} {Y}";
        }

    }
}
