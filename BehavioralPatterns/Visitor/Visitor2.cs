using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Visitor
{
    class Visitor2 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            Console.WriteLine($"Visitor2 visits {elementA.Name}");
        }

        public override void VisitElementB(ElementB elementB)
        {
            Console.WriteLine($"Visitor2 visits {elementB.Name}");
        }
    }
}
