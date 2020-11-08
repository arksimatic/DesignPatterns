using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public interface IIterator
    {
        public bool hasNext();
        public Object next();
    }
}
