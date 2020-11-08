using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public interface IContainer
    {
        public IIterator GetIterator();
    }
}
