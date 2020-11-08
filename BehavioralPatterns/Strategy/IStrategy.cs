using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    public interface IStrategy
    {
        public int Execute(int a, int b);
    }
}
