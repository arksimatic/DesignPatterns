using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Visitor
{
    class ElementA : Element
    {
        public ElementA(string name) : base(name) { }
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
    }
}
