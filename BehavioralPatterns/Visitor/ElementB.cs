using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Visitor
{
    class ElementB : Element
    {
        public ElementB(string name) : base(name) { }
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }
    }
}
