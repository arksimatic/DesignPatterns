using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Visitor
{
    abstract class Element
    {
        public string Name;

        public Element(string name)
        {
            Name = name;
        }

        public abstract void Accept(Visitor visitor);
    }
}
