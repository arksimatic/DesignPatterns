using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class Ball : Thing
    {
        public Ball(Color color) : base(color)
        {
            
        }
        public override void print()
        {
            Console.WriteLine("I'm a ball and my color is " + color.color());
        }
    }
}
