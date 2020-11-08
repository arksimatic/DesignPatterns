using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

    }
}
