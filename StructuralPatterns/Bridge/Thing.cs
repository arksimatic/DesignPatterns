using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge
{
    public abstract class Thing
    {
        protected Color color;
        public Thing(Color color) 
        {
            this.color = color;
        }
        abstract public void print();
    }
}

//overall you can add more colors and more shapes but it doesn't make it grow like it would be BlueSquare, BlueCircle, BlackSquare etc.
//composition over inheritance