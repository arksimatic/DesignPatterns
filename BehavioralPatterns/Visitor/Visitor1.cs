using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Visitor
{
    class Visitor1 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            Console.WriteLine($"Visitor1 visits {elementA.Name}");
        }

        public override void VisitElementB(ElementB elementB)
        {
            Console.WriteLine($"Visitor1 visits {elementB.Name}");
        }
    }
}
