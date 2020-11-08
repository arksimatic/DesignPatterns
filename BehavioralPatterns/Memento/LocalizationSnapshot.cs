using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Memento
{
    class LocalizationSnapshot
    {
        private Localization localizaton;
        string city;
        int x, y;
        public LocalizationSnapshot(Localization localization, string city, int x, int y)
        {
            this.localizaton = localization;
            this.city = city;
            this.x = x;
            this.y = y;
        }

        public void Restore()
        {
            localizaton.City = city;
            localizaton.X = x;
            localizaton.Y = y;
        }

    }
}
